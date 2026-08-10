public class Solution
{

    // Stack Optimization
    public int LargestRectangleArea(int[] heights)
    {
        int[] indexStack = new int[heights.Length];
        int[] heightStack = new int[heights.Length];
        int stackIndex = -1;
        int maxHeight = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            int curIndex = i;
            int curHeight = heights[i];
            while (stackIndex > -1 && heights[i] < heightStack[stackIndex])
            {
                int maybeMax = (i - indexStack[stackIndex]) * heightStack[stackIndex];
                maxHeight = Math.Max(maybeMax, maxHeight);
                curIndex = indexStack[stackIndex];  // set curent index to the leftmost possible column
                stackIndex--;
            }
            indexStack[++stackIndex] = curIndex;
            heightStack[stackIndex] = curHeight;
        }
        while (stackIndex > -1)
        {
            maxHeight = Math.Max(maxHeight, (heights.Length - indexStack[stackIndex]) * heightStack[stackIndex]);
            stackIndex--;
        }

        return maxHeight;
    }
}
