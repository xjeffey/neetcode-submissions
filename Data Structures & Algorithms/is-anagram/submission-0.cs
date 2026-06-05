public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<string, int> s1 = new Dictionary<string, int>();
        Dictionary<string, int> t1 = new Dictionary<string, int>();

        for(int i = 0; i < s.Length; i++)
        {
            string curr = s[i].ToString();

            if(!s1.ContainsKey(curr))
            {
                s1.Add(curr, 0);
            }

            s1[curr] += 1;
        }

        for(int i = 0; i < t.Length; i++)
        {
            string curr = t[i].ToString();

            if(!t1.ContainsKey(curr))
            {
                t1.Add(curr, 0);
            }

            t1[curr] += 1;
        }

        if (s1.Count != t1.Count)
        {
            return false;
        }

        foreach(string key in s1.Keys)
        {
            int count = s1[key];

            if(t1.ContainsKey(key))
            {
                if(!(t1[key] == count))
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}
