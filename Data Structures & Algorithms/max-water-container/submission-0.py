class Solution:
    def maxArea(self, height: List[int]) -> int:
        x1 = 0
        x2 = len(height) - 1
        maxVolume = 0
        while x1 < x2:
            volume = self.calculateVolume(x1, x2, height[x1], height[x2])
            maxVolume = max(maxVolume, volume)

            if height[x1] < height[x2]:
                x1 += 1
            else:
                x2 -= 1

        return maxVolume

    def calculateVolume(self, x1: int, x2: int, h1: int, h2: int) -> int:
        return min(h1, h2) * (x2 - x1)