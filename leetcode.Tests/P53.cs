using System;
using Xunit;

namespace P53.Tests
{
    public class Solution_case
    {
        private Solution solution_;
        public Solution_case() {
            solution_ = new Solution();
        }
    
        [Theory]
        [InlineData(-2,1,-3,4,-1,2,1,-5,4,
                    6)]
        
        public void Test2(params int[] nums)
        {
            int exp = nums[nums.Length - 1];

            int[] A = new int[nums.Length - 1];
            Array.Copy(nums, A, nums.Length - 1);

            var res = solution_.MaxSubArray(
                A
            );

            Assert.Equal(exp, res);
        }
    }
    
}
