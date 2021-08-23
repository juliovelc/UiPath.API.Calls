using System;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http;

namespace UiPath.API.Calls
{
    public static class UiPathAuthentication
    {
        private static string CreateAuthRequest() =>
            JsonConvert.SerializeObject(new APIBase.APIAuthData());


        public static void Authenticate()
        {
            string uri = "https://account.uipath.com/oauth/token";
            string body = CreateAuthRequest();
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(body, Encoding.UTF8, "application/json");

                var response = client.PostAsync(uri, content).Result;
                string result = response.Content.ReadAsStringAsync().Result;
                APIBase.Token = JObject.Parse(result)["access_token"].ToString();
            }
        }
    }
}
