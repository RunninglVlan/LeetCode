public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strings) {
        Dictionary<int[], IList<string>> groups = new(ArrayComparer<int>.Instance);
        foreach (string letters in strings) {
            var frequencies = new int[26];
            foreach (char letter in letters) {
                frequencies[letter - 'a']++;
            }
            if (!groups.TryGetValue(frequencies, out var group)) {
                groups[frequencies] = group = [];
            }
            group.Add(letters);
        }
        return [.. groups.Values];
    }
}

sealed class ArrayComparer<T> : IEqualityComparer<T[]> {
    public static readonly ArrayComparer<T> Instance = new();

    public bool Equals(T[]? a, T[]? b) {
        return a == b || a != null && b != null && a.SequenceEqual(b);
    }

    public int GetHashCode(T[] items) {
        var hash = new HashCode();
        foreach (var item in items) {
            hash.Add(item);
        }
        return hash.ToHashCode();
    }
}
