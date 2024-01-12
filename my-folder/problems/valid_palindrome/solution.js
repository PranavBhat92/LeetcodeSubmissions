/**
 * @param {string} s
 * @return {boolean}
 */
var isPalindrome = function(s) {
    const match = /[^a-zA-Z0-9]/g;
    const straight = s.toLowerCase();
    const reverse = straight.split('').reverse().join('');
    return straight.replace(match, '') === reverse.replace(match, '');
};