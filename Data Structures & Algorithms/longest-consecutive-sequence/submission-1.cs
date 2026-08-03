public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> setOfNums = new(nums);
        Dictionary<int, int> firstNumToLastNum = new();
        foreach(int num in nums)
        {
            if (!setOfNums.Contains(num-1)) firstNumToLastNum[num] = num;
        }
        int biggest = 0;
        foreach(int num in firstNumToLastNum.Keys)
        {
            int counter = num + 1;
            while(setOfNums.Contains(counter)) firstNumToLastNum[num] = counter++;
            if (firstNumToLastNum[num] - num + 1 > biggest) biggest = firstNumToLastNum[num] - num + 1;
        }
        return biggest;
    }
}
