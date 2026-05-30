public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int len = nums.Length;
        int[] result = new int[len];

        int sumBefore = 1;
        for (int i = 0; i < len; i++) {
            result[i] = sumBefore;
            sumBefore *= nums[i];
        }

        int sumAfter = 1;
        for (int i = len - 1; i >= 0; i--) {
            result[i] *= sumAfter;
            sumAfter *= nums[i];
        }

        return result;
    }
}
