public class Solution {
    public double solution(int[] arr) {
        double avg = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            avg += arr[i];
        }
        double answer = avg / arr.Length;
        
        return answer;
    }
}