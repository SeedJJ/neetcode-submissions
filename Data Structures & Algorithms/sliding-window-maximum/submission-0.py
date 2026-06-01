class Solution:
    def maxSlidingWindow(self, nums: List[int], k: int) -> List[int]:
        max_index = deque()
        res = []
        for right in range(len(nums)):
            while len(max_index) > 0 and nums[right] > nums[max_index[-1]]:
                max_index.pop()
            max_index.append(right)
            if max_index[0] <= right - k:
                max_index.popleft()
            if right >= k - 1:
                res.append(nums[max_index[0]])
        return res
