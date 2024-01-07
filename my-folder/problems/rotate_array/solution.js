/**
 * @param {number[]} nums
 * @param {number} k
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var rotate = function (nums, k) {
    let t = k % nums.length;
    reverse(nums, 0, nums.length- t-1);
    reverse(nums, nums.length - t, nums.length - 1);
    reverse(nums, 0, nums.length - 1);
};

var reverse = function (nums, low, high) {
    while (low < high) {
        let temp = nums[low];
        nums[low++] = nums[high];
        nums[high--] = temp;
    }
}