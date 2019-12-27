using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ASM2
{
   public class Test
    {
        
        private static bool IsNumber(string value)
        {
            if (value != "")
                return Regex.IsMatch(value, @"^[0-9]\d*\.?[0]*$");
            else return true;
        }
        public int CheckFormIDStd(string Stdid)
        {
            string subid = Stdid.Substring(2);
            if ((Stdid.StartsWith("GT") || Stdid.StartsWith("GC")) && Stdid.Length == 7 && IsNumber(subid) == true)
            {
                return 0;
            }
            return -1;
        }
        public int CheckFormIDLec(string lecId)
        {
            if (IsNumber(lecId) == true)
            {
                return 0;
            }
            return -1;
        }
    }
}
