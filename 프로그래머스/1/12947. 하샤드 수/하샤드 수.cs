using System;

public class Solution {
    public bool solution(int x) {
        string temp = x.ToString();
            int sum = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                sum += (int)Char.GetNumericValue(temp[i]);
            }
            bool answer = x % sum == 0 ? true:false;
            return answer;
    }
}