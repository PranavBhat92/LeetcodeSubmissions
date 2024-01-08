public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        if(s==t) return true;

        Dictionary<char, int> sCounts = new();
        Dictionary<char, int> tCounts = new();

        for(int i=0; i<s.Length; i++) {
            sCounts[s[i]] = (sCounts.ContainsKey(s[i]) ? sCounts[s[i]] : 0) + 1;
            tCounts[t[i]] = (tCounts.ContainsKey(t[i]) ? tCounts[t[i]] : 0) + 1;
        }

        foreach(char c in sCounts.Keys) {
            if(!tCounts.ContainsKey(c)) return false;
            if(tCounts[c] != sCounts[c]) return false;
        }
        return true;
    }
}