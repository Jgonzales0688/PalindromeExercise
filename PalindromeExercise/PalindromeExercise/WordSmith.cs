﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string myString)
        { 
            return myString.SequenceEqual(myString.Reverse());
        }
    }
}
