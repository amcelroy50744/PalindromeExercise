using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPaldrome(string word)
        {
            var reverse = string.Concat(word.Reverse());
            if (reverse == word)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
