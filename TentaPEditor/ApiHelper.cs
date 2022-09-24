using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TentaPEditor
{
    public class Api
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private string apiBaseUrl;

        public Api(string baseUrl, string token)
        {
            apiBaseUrl = baseUrl;
            httpClient.DefaultRequestHeaders.Authorization =   new AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<HttpResponseMessage> PostRequestAsync(string url, string body)
        {
            HttpContent content = new StringContent(body, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(new Uri(apiBaseUrl + url), content);
            return response;
        }
    }
}
