public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> remainders = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int curr = nums[i];
            int r = target - curr;

            if(remainders.ContainsKey(r))
            {
                int rPos = remainders[r];
                return new int[] {rPos, i};
            }

            if(!(remainders.ContainsKey(curr)))
            {
                remainders.Add(curr, i);
            }
        }

        return new int[] {-1, -1};
    }
}
