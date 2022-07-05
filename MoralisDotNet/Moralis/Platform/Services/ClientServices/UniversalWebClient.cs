
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks;
using Moralis.Platform.Abstractions;
using Moralis.Platform.Services.Models;
using Moralis.Platform.Utilities;
using BCLWebClient = System.Net.Http.HttpClient;
using WebRequest = Moralis.Platform.Services.Models.WebRequest;

namespace Moralis.Platform.Services
{
    /// <summary>
    /// A universal implementation of <see cref="IWebClient"/>.
    /// </summary>
    public class UniversalWebClient : IWebClient
    {
        static HashSet<string> ContentHeaders { get; } = new HashSet<string>
        {
            { "Allow" },
            { "Content-Disposition" },
            { "Content-Encoding" },
            { "Content-Language" },
            { "Content-Length" },
            { "Content-Location" },
            { "Content-MD5" },
            { "Content-Range" },
            { "Content-Type" },
            { "Expires" },
            { "Last-Modified" }
        };

        public UniversalWebClient() : this(new BCLWebClient { }) { }

        public UniversalWebClient(BCLWebClient client) => Client = client;

        BCLWebClient Client { get; set; }

        public async Task<Tuple<HttpStatusCode, string>> ExecuteAsync(WebRequest httpRequest, IProgress<IDataTransferLevel> uploadProgress, IProgress<IDataTransferLevel> downloadProgress, CancellationToken cancellationToken)
        {
            uploadProgress ??= new Progress<IDataTransferLevel> { };
            downloadProgress ??= new Progress<IDataTransferLevel> { };

            HttpRequestMessage message = new HttpRequestMessage(new HttpMethod(httpRequest.Method), httpRequest.Target);

            // Fill in zero-length data if method is post.
            if ((httpRequest.Data is null && httpRequest.Method.ToLower().Equals("post") ? new MemoryStream(new byte[0]) : httpRequest.Data) is Stream { } data)
            {
                message.Content = new StreamContent(data);
            }

            if (httpRequest.Headers != null)
            {
                foreach (KeyValuePair<string, string> header in httpRequest.Headers)
                {
                    if (ContentHeaders.Contains(header.Key))
                    {
                        message.Content.Headers.Add(header.Key, header.Value);
                    }
                    else
                    {
                        message.Headers.Add(header.Key, header.Value);
                    }
                }
            }

            // Avoid aggressive caching on Windows Phone 8.1.

            message.Headers.Add("Cache-Control", "no-cache");
            message.Headers.IfModifiedSince = DateTimeOffset.UtcNow;

            // TODO: (richardross) investigate progress here, maybe there's something we're missing in order to support this.

            uploadProgress.Report(new DataTransferLevel { Amount = 0 });

            HttpResponseMessage sendResp = await Client.SendAsync(message, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
            //HttpResponseMessage response = httpMessageTask.Result;
            uploadProgress.Report(new DataTransferLevel { Amount = 1 });

            Stream readStream = await sendResp.Content.ReadAsStreamAsync();

            MemoryStream resultStream = new MemoryStream { };
            //Stream responseStream = streamTask.Result;

            int bufferSize = 4096;
            int bytesRead = 0;
            byte[] buffer = new byte[bufferSize];
            long totalLength = -1;
            long readSoFar = 0;

            try
            {
                totalLength = readStream.Length;
            }
            catch { };

            bytesRead = await readStream.ReadAsync(buffer, 0, bufferSize, cancellationToken);

            while (bytesRead > 0)
            {
                cancellationToken.ThrowIfCancellationRequested();

                await resultStream.WriteAsync(buffer, 0, bytesRead, cancellationToken);

                cancellationToken.ThrowIfCancellationRequested();
                readSoFar += bytesRead;

                if (totalLength > -1)
                {
                    downloadProgress.Report(new DataTransferLevel { Amount = 1.0 * readSoFar / totalLength });
                }

                bytesRead = await readStream.ReadAsync(buffer, 0, bufferSize, cancellationToken);
            }

            // If getting stream size is not supported, then report download only once.
            if (totalLength == -1)
            {
                downloadProgress.Report(new DataTransferLevel { Amount = 1.0 });
            }

            byte[] resultAsArray = resultStream.ToArray();
            resultStream.Dispose();

            // Assume UTF-8 encoding.
            return new Tuple<HttpStatusCode, string>(sendResp.StatusCode, Encoding.UTF8.GetString(resultAsArray, 0, resultAsArray.Length));
        }
    }
}
