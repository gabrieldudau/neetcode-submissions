public class Solution {
    public bool IsValid(string s) {
        Stack<char> chars = new();
        Dictionary<char, char> brackets = new Dictionary<char, char>{ {'(', ')'}, {'[', ']'}, {'{', '}'}};
        foreach(char c in s)
        {
            if (brackets.ContainsKey(c)) chars.Push(c);
            else if (chars.Count == 0 || brackets[chars.Pop()] != c) return false;
        }
        return chars.Count == 0;
    }
}
