// https://leetcode.com/problems/maximum-subarray-with-equal-products
// Note: Doesn't use sliding window yet

public class Solution {
    public int MaxLength(int[] numbers) {
        var max = 0;
        for (var start = 0; start < numbers.Length; start++) {
            int number = numbers[start];
            int product = number, gcd = number, lcm = number;
            for (int end = start + 1; end < numbers.Length; end++) {
                number = numbers[end];
                product *= number;
                gcd = Mathf.GreatestCommonDivisor(gcd, number);
                lcm = Mathf.LeastCommonMultiple(lcm, number);
                bool isProductEquivalent = product == lcm * gcd;
                if (!isProductEquivalent) {
                    break;
                }
                int length = end - start + 1;
                max = int.Max(length, max);
            }
        }
        return max;
    }
}

static class Mathf {
    /// Euclidean algorithm
    public static int GreatestCommonDivisor(int a, int b) {
        // r is a remainder
        int rPrevious = a, r = b;
        while (r != 0) {
            (rPrevious, r) = (r, rPrevious % r);
        }
        return rPrevious;
    }

    public static int LeastCommonMultiple(int a, int b) {
        int gcd = GreatestCommonDivisor(a, b);
        return Math.Abs(a) / gcd * Math.Abs(b);
    }
}
