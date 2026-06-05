public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> tracker = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int current = nums[i];

            if(!tracker.ContainsKey(current))
            {
                tracker.Add(current, 0);
            }

            tracker[current] += 1;
        }

        foreach(int key in tracker.Keys)
        {
            int count = tracker[key];

            if (count > 1)
            {
                return true;
            }
        }

        return false;
    }
}