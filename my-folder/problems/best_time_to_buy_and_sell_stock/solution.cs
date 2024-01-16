public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0, right = 1, max = 0;

        while(right<prices.Length) {
            if(prices[right] < prices[left]){
                left = right;
            } else {
                int temp = prices[right] - prices[left];
                max = Math.Max(max, temp);
            }
            right++;
        }
        return max;
    }
}