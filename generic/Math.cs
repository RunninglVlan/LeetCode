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
