/**
 * @param {string} s
 * @return {boolean}
 */
var isValid = function(s) {
    const map = new Map(); 
    map.set(']', '[');
    map.set('}', '{');
    map.set(')', '(');
    const stack = [];

    for(const c of s) { // Time O(n)
        if(map.has(c)) {
            if(stack.length != 0 && map.get(c) === stack[stack.length-1]) {
                stack.pop();
            } else {
                return false;
            }
        } else {
            stack.push(c);
        }
    }
    
    return stack.length === 0;
};