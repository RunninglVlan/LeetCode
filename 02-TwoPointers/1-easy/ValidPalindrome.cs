// https://leetcode.com/problems/valid-palindrome/

public class Solution {
    public bool IsPalindrome(string candidate) {
        for (int l = 0, r = candidate.Length - 1; l < r; l++, r--) {
            char left = candidate[l];
            while (!char.IsLetterOrDigit(left) && l < r) {
                left = candidate[++l];
            }
            char right = candidate[r];
            while (!char.IsLetterOrDigit(right) && l < r) {
                right = candidate[--r];
            }
            if (char.ToUpper(left) != char.ToUpper(right)) {
                return false;
            }
        }
        return true;
    }
}
