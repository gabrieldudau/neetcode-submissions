public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] output = new int[nums.Length];
        int[] suffix = new int[nums.Length];
        output[0] = 1;
        suffix[nums.Length - 1] = nums[nums.Length - 1];
        for(int i = 1; i < nums.Length; i++)
        {
            output[i] = output[i - 1] * nums[i-1];
        }
        for(int j = nums.Length - 2; j >= 0; j--)
        {
            output[j] *= suffix[j+1];
            suffix[j] = suffix[j+1] * nums[j];
        }
        return output;
    }
}
