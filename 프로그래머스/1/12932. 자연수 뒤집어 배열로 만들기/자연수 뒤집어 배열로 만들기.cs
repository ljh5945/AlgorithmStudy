using System;
using System.Linq;

public class Solution {
    public int[] solution(long n) {
        string str = n.ToString();
        int[] answer = new int[str.Length];
        
        for (int i = 0; i < str.Length; i++)
        {
            answer[i] = int.Parse(str[i].ToString());
        }
        
        Array.Reverse(answer);
        return answer;
    }
}