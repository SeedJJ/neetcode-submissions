public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> result = new List<List<string>>();
        List<int> seen = new List<int>();
        for (int i = 0; i < strs.Length; i++) {
            if (!seen.Contains(i)) {
                List<string> anagrams = new List<string>();

                anagrams.Add(strs[i]);
                seen.Add(i);

                for (int j = i + 1; j < strs.Length; j++) {
                    if (!seen.Contains(j) && IsAnagram(strs[i], strs[j])) {
                        anagrams.Add(strs[j]);
                        seen.Add(j);
                    }
                }
                result.Add(anagrams);
            }
        }

        return result;
    }

    public bool IsAnagram(string s, string t) {
            int[] sLetterCount = new int[26];
            int[] tLetterCount = new int[26];

            fillLetterCount(s, sLetterCount);
            fillLetterCount(t, tLetterCount);

            for (int i = 0; i < 26; i++) {
                if (sLetterCount[i] != tLetterCount[i]) {
                    return false;
                }
            }

            return true;
        }

        void fillLetterCount(string s, int[] letterCount) {
            foreach (char c in s) {
                letterCount[c - 'a']++;
            }
        }
}
