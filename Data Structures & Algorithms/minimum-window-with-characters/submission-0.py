class Solution:
    def minWindow(self, s: str, t: str) -> str:
        if len(t) > len(s):
            return ""

        t_count = self.charCountinStr(t)
        window_count = {}
        have = 0
        need = len(t_count)
        left = 0
        res = ""
        res_len = len(s) + 1
        for right in range(len(s)):
            char = s[right]
            window_count[char] = window_count.get(char, 0) + 1

            if char in t_count and window_count[char] == t_count[char]:
                have += 1

            while have == need:
                window_len = right - left + 1
                if window_len < res_len:
                    res = s[left:right + 1]
                    res_len = window_len
                
                left_char = s[left]
                window_count[left_char] -= 1
                if left_char in t_count and window_count[left_char] < t_count[left_char]:
                    have -= 1
                left += 1

        return res

    def charCountinStr(self, s: str) -> dict:
        count = {}
        for c in s:
            count[c] = count.get(c, 0) + 1
        return count
