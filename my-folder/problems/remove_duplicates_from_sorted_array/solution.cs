public class Solution {
    public int RemoveDuplicates(int[] nums) {

        int uniqueCount = 1; // Also acts as index
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[uniqueCount - 1])
            {
                nums[uniqueCount] = nums[i];
                uniqueCount++;
            }
        }

        // Set remaining elements to default value
        for (int i = uniqueCount; i < nums.Length; i++)
        {
            nums[i] = default(int);
        }
        
        return uniqueCount;
    }
}