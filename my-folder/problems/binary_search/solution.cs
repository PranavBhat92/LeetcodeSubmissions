public class Solution {
    public int Search(int[] nums, int target) {
        int low=0, high = nums.Length-1;
        while(low <= high) {
            int mid = low + (high-low)/2;

            if(nums[mid] == target) {
                return mid;
            } else if(target > nums[mid]){
                low = mid + 1;
            } else {
                high = mid - 1;
            }
        }
        return -1;
    }
}