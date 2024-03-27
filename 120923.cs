using System.Diagnostics;

namespace programmers120923;
using System;
using System.Linq;
public class Solution {
    public int[] solution(int num, int total) {
        int[] answer = new int[num];
        int index = 0;
        int j = 0;
        for(int i = -50;;i++)
        {
            answer[j%num] = i;
            if(total == Enumerable.Sum(answer))
            {
                Array.Sort(answer);
                return answer;
            }
            j++;
        }
    }
}
