using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiPath.API.Calls
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change values in APIBase class to make it work with other uipath orchestrator instances
            UiPathAuthentication.Authenticate();
            UiPathFolders.GetFolderId("Isolated-Modern");
            string queueName = "TestQueue";
            string queueBody = "{\"itemData\":{\"Name\":\"queueName\",\"Priority\":\"Normal\",\"SpecificContent\": {\"testKey\": \"testvalue\"}}}"
                .Replace("queueName", queueName);
            
            UiPathQueue.AddQueueItem(queueBody);



            //StorageBucket Flow
            System.Diagnostics.Process
                .Start("cmd.exe", $"/C {UiPathStorageBucket.UiRobotLocation} -f {UiPathStorageBucket.UiPathFilePath}").WaitForExit();
        }
    }
}
