using System;
using System.Collections.Generic;


namespace P33
{
    public class Solution {
    public int Search(int[] nums, int target) {
        if (nums.Length == 0) return -1;
        return SearchOnNonOrder(nums, 0, nums.Length, target);
    }

    public int SearchOnOrder(int[] nums, int start, int len, int target) {
        if (len == 1) {
            return nums[start] == target ? start : -1;
        }

        int l1 = len / 2;
        int l2 = len -l1;

        // on left
        if (nums[start] <= target && target <= nums[start + l1 - 1]) {
            return SearchOnOrder(nums, start, l1, target);
        // on right
        } else {
            return SearchOnOrder(nums, start + l1, l2, target);
        }
    }

    public int SearchOnNonOrder(int[] nums, int start, int len, int target) {
        if (len == 1) {
            return nums[start] == target ? start : -1;
        }

        int l1 = len / 2;
        int l2 = len -l1;

        // left ordered
        if (nums[start] <= nums[start + l1 -1]) {
            // on left
            if (nums[start] <= target && target <= nums[start + l1 - 1]) {
                return SearchOnOrder(nums, start, l1, target);
            // on right
            } else {
                return SearchOnNonOrder(nums, start + l1, l2, target);
            }
        } else {
            // on right
            if (nums[start + l1] <= target && target <= nums[start + len - 1]) {
                return SearchOnOrder(nums, start + l1, l2, target);
            // on left
            } else {
                return SearchOnNonOrder(nums, start, l1, target);
            }
        }
    }

    }
}
