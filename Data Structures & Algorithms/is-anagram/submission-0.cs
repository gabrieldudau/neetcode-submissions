public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Count() != t.Count()) return false;
        Dictionary<char, int> keyValuePairs = new();
        foreach(char c in s)
        {
            if (!keyValuePairs.ContainsKey(c)) keyValuePairs[c] = 0;
            keyValuePairs[c] += 1;
        }
        foreach(char c in t)
        {
            if (!keyValuePairs.ContainsKey(c)) return false;
            keyValuePairs[c] -= 1;
            if (keyValuePairs[c] < 0) return false; 
        }
        return true;
    }
}
