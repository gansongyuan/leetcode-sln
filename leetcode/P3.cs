using System;
using System.Collections.Generic;

namespace P3
{
    public class Solution {

    public int LengthOfLongestSubstring(string s) {
        if (s.Length == 0) return 0;

        int i = -1;
        int j = 0;
        int[] map = new int[256];
        for(var k = 0; k<map.Length; k++)
            map[k] = -1;

        int res = 0;
        while(j < s.Length) {
            if (map[s[j]] > i) {
                i = map[s[j]];
            }
            
            res = j - i > res ? j - i : res;

            map[s[j]] = j;
            j++;
        }

        return res; 
    }

    }
}