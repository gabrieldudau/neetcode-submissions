public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        Stack<(int index, int height)> stack = new();
        stack.Push((0, heights[0]));
        int maxHeight = 0;
        for (int i = 1; i < heights.Length; i++)
        {
            (int index, int height) cur = (i, heights[i]);
            while (stack.Count > 0 && heights[i] < stack.Peek().height)
            {
                (int index, int height) indexHeight = stack.Pop();
                int maybeMax = (i - indexHeight.index) * indexHeight.height;
                maxHeight = Math.Max(maybeMax, maxHeight);
                cur.index = indexHeight.index;  // set curent index to the leftmost possible column
            }
            stack.Push(cur);
        }
        while (stack.Count > 0)
        {
            var cur = stack.Pop();
            maxHeight = Math.Max(maxHeight, (heights.Length - cur.index) * cur.height);
        }

        return maxHeight;
    }
}
