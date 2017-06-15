using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteBookBusinessLogic
{
    public static class PostBL
    {
        public static bool CheckPost(string content)
        {
            if(content.Length > 5000)
            {
                return false;
            }
            return true;
        }
    }
}
