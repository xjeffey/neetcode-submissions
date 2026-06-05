public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> grouped = new Dictionary<string, List<string>>();
        Dictionary<string, Dictionary<string, int>> letterCount = new Dictionary<string, Dictionary<string, int>>();

        //check for char length 
        foreach(string word in strs)
        {
            char[] letters = word.ToCharArray();
            Array.Sort(letters);
            string key = string.Join("", letters);


            if(!(grouped.ContainsKey(key)))
            {
                grouped.Add(key, new List<string>());
            }

            grouped[key].Add(word);
        }

        return grouped.Values.ToList();
    }
}
