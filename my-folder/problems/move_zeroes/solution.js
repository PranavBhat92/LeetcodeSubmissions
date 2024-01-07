/**
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var moveZeroes = function (nums) {
    let snowBall = 0;
    for (let i = 0; i < nums.length; i++) {
        if (nums[i] === 0) {
            snowBall++;
        } else if (snowBall > 0) {
            let temp = nums[i];
            nums[i] = 0;
            nums[i - snowBall] = temp;
        }
    }
};