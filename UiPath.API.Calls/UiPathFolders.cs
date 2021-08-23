using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace UiPath.API.Calls
{
    public static class UiPathFolders
    {

        public static void GetFolderId(string folder)
        {
            string uri = $@"https://cloud.uipath.com/{APIBase.Account}/{APIBase.Tenant}/odata/Folders";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", APIBase.Token);
                client.DefaultRequestHeaders.Add("X-UIPATH-TenantName", APIBase.Tenant);
                HttpResponseMessage response = client.GetAsync(uri).Result;
                string result = response.Content.ReadAsStringAsync().Result;

                APIBase.FolderId = JObject.Parse(result)
                    .SelectToken($"$..value[?(@.DisplayName=='{folder}')].Id").ToString();
            }

        }


    }
}
