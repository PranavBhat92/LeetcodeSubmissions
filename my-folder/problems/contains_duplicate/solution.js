/**
 * @param {number[]} nums
 * @return {boolean}
 */
var containsDuplicate = function(nums) {
    let isDuplicate = false;
    const visited = {};

    if(nums.length == 1) return false;

    for(let i=0; i<nums.length; i++) {
        if(visited[nums[i]] != null) {
            isDuplicate = true;
            break;
        } else {
            visited[nums[i]] = i;
        }
    }
    return isDuplicate;
};