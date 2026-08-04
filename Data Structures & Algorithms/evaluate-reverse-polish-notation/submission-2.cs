public class Solution
{

    string[] tokens;
    int left;
    public int EvalRPN(string[] tokens)
    {
        if (tokens.Length == 1) return int.Parse(tokens[0]);
        this.tokens = tokens;
        left = tokens.Length ;
        return evaluate();
    }

    private int evaluate()
    {
        left--;
        string token = tokens[left];
        int right, first;
        if (token == "+" || token == "-" || token == "*" || token == "/")
        {
            switch (tokens[left][0])
            {
                case '+':
                    right = evaluate();
                    first = evaluate();
                    return first + right;
                case '-':
                    right = evaluate();
                    first = evaluate();
                    return first - right;
                case '*':
                    right = evaluate();
                    first = evaluate();
                    return first * right;
                case '/':
                    right = evaluate();
                    first = evaluate();
                    return first / right;
                default:
                    return 0;
            }

        }
        else
        {
            return int.Parse(token);
        }


    }
}
