using System;

namespace UiPath.API.Calls
{
    public static class APIBase
    {
        //Values may change based on the orchestrator API data
        public static string Folder {get;} = "Isolated-Modern";
        public static string Tenant { get; } = "Factory";
        public static string Account { get; } = "naegsgvpee";
        public static string FolderId { get; set; }
        public static string Token { get; set; }

        public class APIAuthData
        {
            //Values may change based on the orchestrator API data
            public string grant_type { get; } = "refresh_token";
            public string client_id { get; } = "8DEv1AMNXczW3y4U15LL3jYf62jK93n5";
            public string refresh_token { get; } = "IQ6212bNXgM4_HBr9IgYKWgW4sU5NEQkr6CHNF4RZ4GPZ";
        }
        
         

        
    }
}
