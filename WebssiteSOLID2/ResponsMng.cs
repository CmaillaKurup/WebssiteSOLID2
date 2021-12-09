using System;
using System.IO;
using System.Net;

namespace WebsideSOLID
{
    public class ResponsMng : IResponseMng
    {
        public void webrequest()
        {
            string text = System.IO.File.ReadAllText(@"/Users/caku/Documents/Skole/H2-igen/WebssiteSOLID2/WebssiteSOLID2/NewFile1.txt");
            
            Console.WriteLine(text);
        }
    }
}