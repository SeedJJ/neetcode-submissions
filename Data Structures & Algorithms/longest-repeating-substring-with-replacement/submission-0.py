class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        count = {}
        left = 0
        max_count = 0
        result = 0

        for right in range(len(s)):
            char = s[right]

            count[char] = count.get(char, 0) + 1
            max_count = max(max_count, count[char])

            window_length = right - left + 1

            if window_length - max_count > k:
                count[s[left]] -= 1
                left += 1

            result = max(result, right - left + 1)

        return result
        