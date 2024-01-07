public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int, int> visited = new();
        bool isDuplicate = false;
        for(int i=0; i<nums.Length; i++)
        {
            if(visited.ContainsKey(nums[i])) {
                isDuplicate = true;
                break;
            } else {
                visited[nums[i]] = i;
            }
        }
        return isDuplicate;
    }
}