using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace Common.Http
{
    /// <summary>
    /// <see cref="HttpClient"/>扩展方法
    /// </summary>
    public static class HttpClientExtensions
    {
        /// <summary>
        /// Patch请求
        /// </summary>
        public static Task<HttpResponseMessage> PatchAsync(this HttpClient client, string url, HttpContent content)
        {
            return client.PatchAsync(new Uri(url), content);
        }

        /// <summary>
        /// Patch请求
        /// </summary>
        public static async Task<HttpResponseMessage> PatchAsync(this HttpClient client, Uri uri, HttpContent content)
        {
            HttpMethod method = new HttpMethod("PATCH");
            HttpRequestMessage request = new HttpRequestMessage(method, uri) { Content = content };
            HttpResponseMessage response = await client.SendAsync(request);
            return response;
        }
    }
}