using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
            [Theory]
            [InlineData("read", false)]
            [InlineData("rotator", true)]
            public void Test1(string word, bool expected)
            {
                var test = new WordSmith();
                var actual = test.IsAPaldrome(word);
                Assert.Equal(expected, actual);

            }    
        
    }
}
