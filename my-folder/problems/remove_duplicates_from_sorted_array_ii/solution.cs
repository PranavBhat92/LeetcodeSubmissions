public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int index = 0; // Index for the modified nums

        for (int i = 0; i < nums.Length; i++)
        {
            // Check if the current element is the same as the next two elements
            if (i < nums.Length - 2 && nums[i] == nums[i + 1] && nums[i] == nums[i + 2])
            {
                // Skip the duplicate values (more than two)
                continue;
            }

            // Copy the current element to the modified array
            nums[index++] = nums[i];
        }

        // Fill the remaining elements with default values
        for (int i = index; i < nums.Length; i++)
        {
            nums[i] = default;
        }

        return index;
        
    }
}