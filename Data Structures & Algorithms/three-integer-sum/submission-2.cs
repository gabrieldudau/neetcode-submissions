public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {

        int[] sorted = new int[nums.Length];
        Array.Copy(nums, sorted, nums.Length);
        Array.Sort(sorted);
        List<List<int>> output = new();
        int lastInt = sorted[0] - 1;

        for(int i = 0; i < sorted.Length-2; i++)
        {
            if (sorted[i] == lastInt) continue;
            int toReach = -sorted[i];
            int j = i + 1; 
            int k = sorted.Length - 1;
            while(j < k)
            {
                int sum = sorted[j] + sorted[k];
                if(sum == toReach)
                {
                    output.Add(new List<int>([sorted[i], sorted[j], sorted[k]]));
                    int lastk = k;
                    int lastj = j;
                    while(j < k && sorted[lastj] == sorted[j]) j++;
                    while(j < k && sorted[lastk] == sorted[k]) k--;
                }
                else if(sum < toReach) j++;
                else k--;
            }
            lastInt = sorted[i];
        }
        return output;
    }
}
