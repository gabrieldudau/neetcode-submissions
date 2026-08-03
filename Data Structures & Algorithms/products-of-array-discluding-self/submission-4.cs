public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] output = new int[nums.Length];
        output[0] = 1;
        int suffix = nums[nums.Length - 1];
        int prefix = nums[0];
        for(int i = 1; i < nums.Length; i++)
        {
            output[i] = prefix;
            prefix *= nums[i];
        }
        for(int j = nums.Length - 2; j >= 0; j--)
        {
            output[j] *= suffix;
            suffix *= nums[j];
        }
        return output;
    }
}
