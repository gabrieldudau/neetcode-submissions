public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefix = new int[nums.Length];
        int[] suffix = new int[nums.Length];
        prefix[0] = nums[0];
        suffix[suffix.Length - 1] = nums[nums.Length - 1]; 
        for(int i = 1; i < nums.Length - 1; i++)
        {
            prefix[i] = prefix[i-1] * nums[i];
        }
        for(int j = nums.Length - 2; j > 0; j--)
        {
            suffix[j] = suffix[j+1] * nums[j];
        }
        int[] output = new int[nums.Length];
        output[0] = suffix[1];
        output[nums.Length - 1] = prefix[nums.Length - 2];
        for(int i = 1; i < nums.Length - 1; i++)
        {
            output[i] = prefix[i-1] * suffix[i + 1];
        }
        return output;
    }
}
