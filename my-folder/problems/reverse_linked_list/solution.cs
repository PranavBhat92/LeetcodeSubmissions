/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null) return null;
        if (head.next == null) return head;
        ListNode? cur = head;
        ListNode? after = head.next;
        ListNode? later = after.next;
        // if only 2 nodes, swap them
        if (later == null)
        {
            after.next = head;
            head.next = null;
            return after;
        }
        else
        {
        while (after != null)
        {
            after.next = cur;
            if (cur == head) cur.next = null;
            cur = after;
            after = later;
            if (after != null) later = after.next;
        }
        return cur;
        }
    }
}