public class Solution
{

    public string Encode(IList<string> strs)
    {
        int count = 0;
        foreach (string s in strs)
        
       {
            count += s.Length;
            count += s.Length.ToString().Length;
            count += 1;
        }
        System.Text.StringBuilder output = new(count);
        foreach (string s in strs)
        {
            output.Append(s.Length.ToString());
            output.Append("#");
            output.Append(s);
        }
        return output.ToString();
    }

    public List<string> Decode(string s)
    {
        int curIndex = 0; 
        List<string> output = new();
        while (curIndex < s.Length)
        {
            int nextLen = 0;
            while(s[curIndex] != '#')
            {
                nextLen *= 10;
                nextLen += s[curIndex++] - '0';
            }
            curIndex++;
            int goalIndex = curIndex + nextLen;
            char[] currentString = new char[nextLen];
            int i = 0;
            while(curIndex < goalIndex)
            {
                currentString[i++] = s[curIndex++];
            }
            output.Add(new string(currentString));
        }
        return output;
    }
}
