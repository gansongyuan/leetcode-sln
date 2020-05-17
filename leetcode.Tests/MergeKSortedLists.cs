using System;
using Xunit;

namespace P33.Tests
{
    public class Solution_case
    {
        private Solution solution_;
        public Solution_case() {
            solution_ = new Solution();
        }
    
        [Theory]
        [InlineData(0,
                    0, 0)]
        [InlineData(1,
                    0, -1)]
        [InlineData(1, 2,
                    2, 1)]
        [InlineData(2, 1,
                    2, 0)]
        [InlineData(0, 1, 2, 5,
                    2, 2)]
        [InlineData(5, 0, 1, 2,
                    2, 3)]
        [InlineData(5, 0, 1,
                    2, -1)]
        [InlineData(3, 5, 0, 1, 2, 
                    1, 3)]
        [InlineData(3, 5, 6, 7,  0, 1, 2, 
                    1, 5)]
        [InlineData(3, 5, 6, 7,  0, 1, 2, 
                    7, 3)]
        [InlineData(4, 5, 6, 7, 0, 1, 2,
                    0, 4)]
        public void Test2(params int[] nums)
        {
            int target = nums[nums.Length - 2];
            int exp = nums[nums.Length - 1];

            int[] nums2 = new int[nums.Length - 2];
            Array.Copy(nums, nums2, nums.Length - 2);

            var res = solution_.Search(
                nums2, target
            );
            Assert.Equal(exp, res);
        }
    }
    
}

