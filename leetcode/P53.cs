using System;
using System.Collections.Specialized;

namespace P53
{
    public class Solution {

    public int MaxSubArray(int[] nums) {
        int sum = 0;
        int max = Int32.MinValue;
        foreach(var num in nums) {
            sum += num;
            max = Math.Max(sum, max);
            sum = Math.Max(sum, 0);
        }
        return max;
    }

    }
}