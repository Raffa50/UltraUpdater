using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Aldrigos.UltraUpdater
{
    internal static class Utils
    {
        public static string GetFileMd5(string path)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    return Convert.ToBase64String( md5.ComputeHash(stream) );
                }
            }
        }
    }
}
