public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) {
            return 0;
        }

        Array.Sort(nums);

        int longest = 1;
        int current = 1;

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] == nums[i - 1]) {
                continue;
            }

            if (nums[i] == nums[i - 1] + 1) {
                current++;
            } else {
                current = 1;
            }

            if (current > longest) {
                longest = current;
            }
        }

        return longest;
    }
}
