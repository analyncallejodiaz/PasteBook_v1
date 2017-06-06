using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasteBookBusinessLogic.Manager
{
    class SaltGenerator
    {
        private static RNGCryptoServiceProvider crypto = null;
        private const int SaltSize = 18;

        public SaltGenerator()
        {
            crypto = new RNGCryptoServiceProvider();
        }
        public static string GetSaltString()
        {
            crypto = new RNGCryptoServiceProvider();
            byte[] saltBytes = new byte[SaltSize];
            crypto.GetNonZeroBytes(saltBytes);
            return ConversionManager.ConvertByteToString(saltBytes);
        }
    }
}
