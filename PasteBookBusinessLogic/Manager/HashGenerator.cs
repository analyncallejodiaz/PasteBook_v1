using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasteBookBusinessLogic.Manager
{
    class HashGenerator
    {
        public string GetPasswordHash(string input)
        {
            SHA256 sha = new SHA256CryptoServiceProvider();
            byte[] data = ConversionManager.ConvertStringToByte(input);

            return ConversionManager.ConvertByteToString(sha.ComputeHash(data));

        }
    }
}
