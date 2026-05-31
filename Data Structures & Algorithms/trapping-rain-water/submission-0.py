class Solution:
    def trap(self, height: list[int]) -> int:
        left = 0
        right = len(height) - 1
        maxLeft = 0
        maxRight = 0
        volume = 0
        while left < right:
            if height[left] < height[right]:
                if height[left] >= maxLeft:
                    maxLeft = height[left]
                else:
                    volume += maxLeft - height[left]
                left += 1
            else:
                if height[right] >= maxRight:
                    maxRight = height[right]
                else:
                    volume += maxRight - height[right]
                right -= 1
        return volume
