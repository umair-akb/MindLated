﻿using System.Net;
using System.Reflection;

namespace Isolated.Protection.String
{
    internal class OnlineString
    {
        public static string Decoder(string encrypted)
        {
            if (Assembly.GetExecutingAssembly() == Assembly.GetCallingAssembly())
            {
                WebClient webClient = new WebClient();
                return webClient.DownloadString("https://communitykeyv1.000webhostapp.com/Decoder4.php?string=" + encrypted);
                //I will add an php example for this soon maybe
            }   //mb my english is bad
            return "Isolated.png";
        }
    }
}