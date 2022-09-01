using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MonremSys
{

    static class Media
    {
        public static string MediaPath = @"../../Test/";

        public static string UploadFile(string path, ReceivedRemittance rmnc)
        {
            FileInfo finfo = new FileInfo(path);
            string destinationfilepath = MediaPath + rmnc.Receiver.Id + finfo.Extension;
            if (!File.Exists(destinationfilepath))
            {
                File.Copy(path, destinationfilepath);
            }

            return destinationfilepath;
        }
    }
}
