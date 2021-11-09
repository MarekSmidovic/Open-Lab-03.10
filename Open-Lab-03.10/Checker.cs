using System;
using System.Linq;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            char ch = letter;
            int freq = str.Count(f => (f == ch));
            return freq;

        }
    }
}
