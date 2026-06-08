public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        Dictionary<int, List<int>> countFreq = new Dictionary<int, List<int>>();

        foreach(int num in nums)
        {
            if(!(frequency.ContainsKey(num)))
            {
                frequency.Add(num, 0);
            }

            frequency[num] += 1;
        }

        foreach(int key in frequency.Keys)
        {
            int val = frequency[key];

            if(!(countFreq.ContainsKey(val)))
            {
                countFreq.Add(val, new List<int>());
            }

            countFreq[val].Add(key);
        }

        List<int> frequencies = countFreq.Keys.ToList();
        frequencies.Sort();

        List<int> result = new List<int>();

        for(int i = frequencies.Count - 1; i >= 0 && result.Count < k; i--)
        {
            int freq = frequencies[i];

            foreach (int num in countFreq[freq]) {
                result.Add(num);
                if (result.Count == k) {
                    break;
                }
            }
        }

        return result.ToArray();
    }
}
