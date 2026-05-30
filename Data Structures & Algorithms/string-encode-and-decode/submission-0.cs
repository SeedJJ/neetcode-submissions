public class Solution {

    public string Encode(IList<string> strs) {
        string result = "";
        foreach (string str in strs) {
            result += str.Length.ToString() + '#' + str;
        }

        return result;
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int idx = 0;
        while (idx < s.Length) {
            int length = 0;
            while (s[idx] != '#') {
                length = length * 10 + (s[idx] - '0');
                idx++;
            }
            idx++;
            result.Add(s.Substring(idx, length));
            idx += length;
        }
        return result;
   }
}
