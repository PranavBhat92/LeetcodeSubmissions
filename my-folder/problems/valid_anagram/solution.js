/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 * https://leetcode.com/problems/valid-anagram/
 */
var isAnagram = function(s, t, map = new Map()) {
    if(s.length != t.length) return false;

    addFrequesncy(s, map);  // Time O(n) | Space O(1)
    subtractFrequency(t, map); // Time O(n) | Space O(1)
    return checkFrequency(map); // Time O(n)
};

let addFrequesncy = (str, map) => {
    for(const char of str) {
        const count = (map.get(char) || 0) + 1;
        map.set(char, count); 
    }
}

let subtractFrequency = (str, map) => {
    for(const char of str) {
        if(!map.has(char)) continue;
        const count = map.get(char) - 1;
        map.set(char, count);
    }
}

let checkFrequency = map => {
    for(const [char, count] of map) {
        if(count !== 0) return false;
    }
    return true;
}