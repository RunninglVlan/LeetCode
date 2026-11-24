// https://leetcode.com/problems/valid-palindrome/

public class Solution {
    public bool IsPalindrome(string candidate) {
        for (var i = 0; i < candidate.Length / 2; i++) {
            if (candidate[i] != candidate[candidate.Length - 1 - i]) {
                return false;
            }
        }
        return true;
    }
}
