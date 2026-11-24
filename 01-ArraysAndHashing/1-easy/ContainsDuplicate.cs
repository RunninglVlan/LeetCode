// https://leetcode.com/problems/contains-duplicate/

public class Solution {
    public bool ContainsDuplicate(int[] numbers) {
        return numbers.Distinct().Count() != numbers.Length;
    }
}
