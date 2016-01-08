using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Hc2Api
{
    public class Hc2Connection
    {
        private string _url = string.Empty;
        private string _username = string.Empty;
        private string _password = string.Empty;

        public async Task Connect(string Url, string Username, string Password)
        {
            _url = Url;
            _username = Username;
            _password = Password;

            HttpClient httpClient = new HttpClient();
            //httpClient.BaseAddress = new Uri(_url);

            var byteArray = Encoding.ASCII.GetBytes(string.Format("{0}:{1}", _username, _password));
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            HttpResponseMessage response = await httpClient.GetAsync(string.Format("{0}/api/devices", _url));
            HttpContent content = response.Content;
            
            // ... Check Status Code                                 
            int statusCode = (int)response.StatusCode;

            string result = await content.ReadAsStringAsync();
        }
        
    }
}
