public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> scanned = new();

        for(int i=0; i<nums.Length; i++) {
            int comp = target - nums[i];
            if(scanned.ContainsKey(comp)) 
                return new int[] { scanned[comp], i };
            scanned[nums[i]] = i;
        }
        return new int[]{};
    }
}