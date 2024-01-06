/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function (nums, target) {
    visited = {};

    for (let i = 0; i < nums.length; i++) {
        let comp = target - nums[i];
        if (visited[comp] != null) {
            return [visited[comp], i];
        }
        visited[nums[i]] = i;
    }
};