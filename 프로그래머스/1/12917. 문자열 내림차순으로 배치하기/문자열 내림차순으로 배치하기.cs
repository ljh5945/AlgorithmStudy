using System;
public class Solution {
    public string solution(string s) {
        char[] temp = s.ToCharArray();
        Array.Sort(temp);
        Array.Reverse(temp);
        string answer = new string(temp);
        return answer;
    }
}