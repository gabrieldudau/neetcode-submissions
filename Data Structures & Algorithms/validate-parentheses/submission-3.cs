public class Solution
{
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0) return false;
        Stack<char> chars = new();
        foreach (char c in s)
        {
            if(c == '(') chars.Push(')');
            else if(c == '[') chars.Push(']');
            else if(c == '{') chars.Push('}');
            else if (chars.Count == 0 || chars.Pop() != c) return false;
        }
        return chars.Count == 0;
    }
}
