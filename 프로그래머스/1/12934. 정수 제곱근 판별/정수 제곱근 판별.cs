using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;

        var sqrt = Math.Sqrt(n);

        if (sqrt % 1.0 != 0)
            return -1;

        answer = (long)sqrt;

        answer += 1;
        answer *= answer;

        return answer;
    }
}