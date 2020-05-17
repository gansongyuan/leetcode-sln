using System;
using Xunit;

namespace P992.Tests
{
    public class Solution_case
    {
        private Solution solution_;
        public Solution_case() {
            solution_ = new Solution();
        }
    
        [Theory]
        [InlineData(1,
                    2, 0)]
        [InlineData(1,
                    1, 1)]
        [InlineData(1, 2,
                    3, 0)]
        [InlineData(1, 2,
                    1, 2)]
        [InlineData(1,2,1,2,3,
                    2, 7)]
        [InlineData(1,2,1,3,4,
                    3, 3)]

        [InlineData(1,2,1,3,4,4,
                    3, 4)]
        [InlineData(1,2,4,4,5,
                    2, 5)]
        
        public void Test2(params int[] nums)
        {
            int K = nums[nums.Length - 2];
            int exp = nums[nums.Length - 1];

            int[] A = new int[nums.Length - 2];
            Array.Copy(nums, A, nums.Length - 2);

            var res = solution_.SubarraysWithKDistinct_ON(
                A, K
            );

            Assert.Equal(exp, res);
        }
    }
    
}
