using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("kayak", true)]
        [InlineData("redivider",true)]
        [InlineData("level", true)]
        public void Test1(string word1,bool expected )
        {
            var instance = new WordSmith();

            var actual = instance.IsAPalindrome(word1);

            Assert.Equal(expected, actual);
        }
    }
}
