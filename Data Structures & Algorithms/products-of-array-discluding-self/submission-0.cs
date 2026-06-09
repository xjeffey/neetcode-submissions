public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int count = nums.Length;
        int[] result = new int[count];

        for(int i = 0; i < count; i++)
        {
            int current = 1;
            int pos = 0;

            while(pos < count)
            {
                if(!(pos == i))
                {
                    current = current * nums[pos];
                }

                pos += 1;
            }

            result[i] = current;
        }

        return result;
    }
}
