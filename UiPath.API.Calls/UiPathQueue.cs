using System;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;

namespace UiPath.API.Calls
{
    public static class UiPathQueue
    {
        public static void AddQueueItem(string queueJson)
        {
            string uri = $@"https://cloud.uipath.com/{APIBase.Account}/{APIBase.Tenant}/odata/Queues/UiPathODataSvc.AddQueueItem";
            
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", APIBase.Token);
                client.DefaultRequestHeaders.Add("X-UIPATH-TenantName", APIBase.Tenant);
                client.DefaultRequestHeaders.Add("X-UIPATH-OrganizationUnitId", APIBase.FolderId);
                StringContent content = new StringContent(queueJson, Encoding.UTF8, "application/json");
                var response = client.PostAsync(uri, content).Result;   
            }
        }
    }
}
