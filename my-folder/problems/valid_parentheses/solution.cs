public class Solution {
    public bool IsValid(string s) {
        var map = new Dictionary<char, char>{
            ['}'] = '{',
            [')'] = '(',
            [']'] = '[',
        };
        Stack<char> stack = new();

        foreach(char c in s) {
            if(!map.ContainsKey(c)){
                stack.Push(c);
            } else if(stack.Count == 0 || stack.Pop() != map[c]){
                return false;
            }
        }
        return stack.Count == 0;
    }
}