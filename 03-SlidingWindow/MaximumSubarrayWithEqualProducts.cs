public class Solution {
    public int MaxLength(int[] numbers) {
        for (var start = 0; start < numbers.Length; start++) {
            for (int end = numbers.Length; end > start; end--) {
                int[] subarray = numbers[start..end];
            }
        }
        return 0;
    }
}
