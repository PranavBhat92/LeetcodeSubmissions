public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;
        Reverse(nums, 0, nums.Length-k-1);
        Reverse(nums, nums.Length-k, nums.Length-1);
        Reverse(nums, 0, nums.Length-1);
    }

    public static void Reverse(int[] nums, int low, int high) {
        while(low < high) {
            int temp = nums[low];
            nums[low++] = nums[high];
            nums[high--] = temp;
        }
    }
}