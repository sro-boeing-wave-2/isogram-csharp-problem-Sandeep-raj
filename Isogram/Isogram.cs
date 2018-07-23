using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Isogram
{
    public class Isogram
    {
        public bool IsIsogram(string str)
        {
            HashSet<Char> set = new HashSet<char>();
            Regex regex = new Regex("[A-Za-z]");
            foreach (Char c in str)
            {
                if (regex.Match(c.ToString()).Success)
                {
                    if (!(set.Contains(c)))
                        set.Add(c);
                    else
                        return false;
                }
            }
            return true;
        }
    }
}
