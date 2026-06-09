public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int totalProduct = 1;
        int zeros = 0;
        int[] result = new int[nums.Length];

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != 0)
            {
                totalProduct *= nums[i];
            }
            else
            {
                zeros += 1;
            }
        }

        if(zeros > 1)
        {
            return result;
        }
        
        for(int i = 0; i < nums.Length; i++)
        {

            if(zeros > 0)
            {
                result[i] = (nums[i] == 0) ? totalProduct : 0;
            }
            else
            {
                result[i] = totalProduct / nums[i];
            }
        }

        return result;
    }
}
