using System;
using System.Collections.Specialized;

namespace P992
{
    public class Solution {

    public int SubarraysWithKDistinct_ON2(int[] A, int K) {
        int[] map = new int[20000];
        for(var k = 0; k<map.Length; k++)
            map[k] = -1;

        var res = 0;
        for(var i = 0; i<A.Length; i++) {
            var count = 0;
            for (var j = i; j<A.Length; j++) {
                if (map[A[j]] < i || map[A[j]] >= j) {
                    count ++;
                }
                map[A[j]] = j;
                if (count == K) {
                    res ++;
                }
            }
        }
        return res; 
    }

    public int SubarraysWithKDistinct_ON(int[] A, int K) {
        var map = new OrderedDictionary();
        var i = 0;
        var res = 0;
        for(var j = 0; j<A.Length; j++) {
            if (map.Contains(A[j])) {
                map.Remove(A[j]);
            }
            map.Add(A[j], j);
            if (map.Count > K) {
                i = Convert.ToInt32(map[0]) + 1;
                map.RemoveAt(0);
            }
            if (map.Count == K) {
                var next_i = Convert.ToInt32(map[0]) + 1;
                res += next_i - i;
            }
        }
        return res; 
    }

    }
}