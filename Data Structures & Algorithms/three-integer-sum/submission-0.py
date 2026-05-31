class Solution:
    def threeSum(self, nums: list[int]) -> list[list[int]]:
        nums.sort()
        firstNum = 0
        result = []
        while firstNum < len(nums) - 2:
            if firstNum > 0 and nums[firstNum] == nums[firstNum - 1]:
                firstNum += 1
                continue
            matches = self.listOfNumOfSumEqualsNum(nums[firstNum + 1:], 0 - nums[firstNum])
            for match in matches:
                triplet = []
                triplet.append(nums[firstNum])
                for num in match:
                    triplet.append(num)
                result.append(triplet)
            firstNum += 1
        return result

    def listOfNumOfSumEqualsNum(self, nums: list[int], target: int) -> list[list[int]]:
        result = []
        left = 0
        right = len(nums) - 1
        while left < right:
            if nums[left] + nums[right] < target:
                left += 1
            elif nums[left] + nums[right] > target:
                right -= 1
            else:
                result.append([nums[left], nums[right]])
                right -= 1
                left += 1
                while left < right and nums[left] == nums[left - 1]:
                    left += 1
                while left < right and nums[right] == nums[right + 1]:
                    right -= 1
        return result

            


        
