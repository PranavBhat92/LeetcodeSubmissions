public class Solution {
    public void MoveZeroes(int[] nums) {
        int snowBall = 0;
        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i] == 0) {
                snowBall++;
            } else {
                int temp = nums[i];
                nums[i] = 0;
                nums[i-snowBall] = temp;
            }
        }
    }
}