// https://leetcode.com/problems/contains-duplicate/

public class Solution {
    public bool ContainsDuplicate(int[] numbers) {
        Array.Sort(numbers);
        int previous = numbers[0];
        for (var i = 1; i < numbers.Length; i++) {
            int current = numbers[i];
            if (current == previous) {
                return true;
            }
            previous = current;
        }
        return false;
    }
}
