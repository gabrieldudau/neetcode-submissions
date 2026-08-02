public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        int[] counts = new int[26];
        foreach (char c in s)
        {
            counts[c - 'a'] += 1;
        }
        foreach (char c in t)
        {
            int idx = c - 'a';
            counts[idx] -= 1;
            if (counts[idx] < 0) return false;
        }
        return true;
    }
}
