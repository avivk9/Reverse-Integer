//Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-2^31, 2^31 - 1], then return 0.

public class Solution {
    public int Reverse(int x) {
        long num = Convert.ToInt64(x);
        long retVal = 0;
        while(num != 0)
        {
            retVal *= 10;
            retVal += num%10;
            num /= 10;
        }
        if(retVal < -2147483647 || retVal > 2147483647)
            return 0;
        return Convert.ToInt32(retVal);
    }
}