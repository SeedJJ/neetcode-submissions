public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        List<int> result = new List<int>();
        Dictionary<int, int> numFrequency = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            if (!numFrequency.ContainsKey(nums[i])) {
                numFrequency[nums[i]] = 0;
            }
            numFrequency[nums[i]]++;
        }

        result = numFrequency
            .OrderBy(p => p.Value)
            .TakeLast(k)
            .Select(p => p.Key)
            .ToList();

        return result.ToArray();
    }
}
