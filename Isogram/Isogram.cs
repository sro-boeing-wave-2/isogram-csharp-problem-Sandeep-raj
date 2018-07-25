using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
namespace Isogram
{
    public class Isogram
    {
        public bool IsIsogram(string str)
        {
            if(Regex.Replace(str, @"[-\s]", string.Empty).Distinct().Count() == Regex.Replace(str, @"[-\s]", string.Empty).Count())
            return true;
            return false;
        }
    }
}
