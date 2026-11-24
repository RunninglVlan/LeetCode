public class Solution {
    public int MaxLength(int[] numbers) {
        var max = 0;
        for (var start = 0; start < numbers.Length; start++) {
            for (int end = numbers.Length; end > start; end--) {
                int[] subarray = numbers[start..end];
                if (IsProductEquivalent(subarray)) {
                    max = int.Max(subarray.Length, max);
                }
            }
        }
        return max;
    }

    static bool IsProductEquivalent(int[] numbers) {
        int product = numbers[0];
        int gcd = product, lcm = product;
        for (var i = 1; i < numbers.Length; i++) {
            int number = numbers[i];
            product *= number;
            gcd = Mathf.GreatestCommonDivisor(gcd, number);
            lcm = Mathf.LeastCommonMultiple(lcm, number);
        }
        return product == lcm * gcd;
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
