public class Solution {
    public bool hasDuplicate(int[] nums) {
        int len = nums.Length;
        int idx = 0;
        while (idx < len) {
            if (containsNumber(nums, nums[idx], idx)) {
                return true;
            }
            idx++;
        }
        return false;
    }

    bool containsNumber(int[] nums, int num, int exception) {
        int len = nums.Length;
        int idx = 0;
        while (idx < len) {
            if (nums[idx] == num && idx != exception) {
                return true;
            }
            idx++;
        }
        return false;
    }
}