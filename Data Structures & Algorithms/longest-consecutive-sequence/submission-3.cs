public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> setOfNums = new(nums);
        int biggest = 0;
        foreach(int num in setOfNums)
        {
            if (!setOfNums.Contains(num - 1))
            {
                int current = num + 1;
                while(setOfNums.Contains(current)) current++;
                biggest = Math.Max(biggest, current - num);
            }
        }
        return biggest;
    }
}
