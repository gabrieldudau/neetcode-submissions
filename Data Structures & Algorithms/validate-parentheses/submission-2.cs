public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> chars = new();
        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{') chars.Push(c);
            else
            {
                if (chars.Count == 0) return false;
                char pop = chars.Pop();
                if (
                    (pop == '(' && c != ')')
                || (pop == '[' && c != ']')
                || (pop == '{' && c != '}')
                ) return false;
            }


        }
        return chars.Count == 0;
    }
}
