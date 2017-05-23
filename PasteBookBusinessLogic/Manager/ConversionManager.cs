using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteBookBusinessLogic.Manager
{
    public static class ConversionManager
    {
        public static byte[] ConvertStringToByte(string input)
        {
            return ASCIIEncoding.ASCII.GetBytes(input);
        }
        public static string ConvertByteToString(byte[] input)
        {
            return ASCIIEncoding.ASCII.GetString(input);
        }
    }
}
