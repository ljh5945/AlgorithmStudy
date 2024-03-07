using System;

public class Solution
{
    public int[] solution(string s)
    {
        int[] answer = new int[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            string target = s.Substring(0, i);

            int min = 9999;
            for (int j = 0; j < target.Length; j++)
            {
                if (target[j] == s[i])
                    if (min > i - j)
                        min = i - j;
            }
            answer[i] = min == 9999 ? -1 : min;
        }

        return answer;
    }
}