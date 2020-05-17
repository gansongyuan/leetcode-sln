using System;
using Xunit;

namespace P3.Tests
{
    public class Solution_case
    {
        private Solution solution_;
        public Solution_case() {
            solution_ = new Solution();
        }
    
        [Theory]
        [InlineData("ababc", 3)]
        [InlineData("", 0)]
        [InlineData("a", 1)]
        [InlineData("abc", 3)]
        [InlineData("abab", 2)]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("dvdf", 3)]
        [InlineData("anviaj", 5)]
        public void Test2(string s, int exp)
        {
            var res = solution_.LengthOfLongestSubstring(
                s );
            Assert.Equal(exp, res);
        }
    }
    
}
