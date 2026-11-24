public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strings) {
        Dictionary<char[], IList<string>> groups = new(ArrayComparer<char>.Instance);
        foreach (string letters in strings) {
            char[] array = letters.ToCharArray();
            Array.Sort(array);
            if (!groups.TryGetValue(array, out var group)) {
                groups[array] = group = [];
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
