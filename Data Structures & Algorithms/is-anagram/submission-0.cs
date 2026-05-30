public class Solution {
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
