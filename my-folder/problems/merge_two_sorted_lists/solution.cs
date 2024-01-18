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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode dummy = new();
        ListNode runner = dummy;

        while(list1 != null && list2 != null) {
            if(list1.val <= list2.val) {
                runner.next = list1;
                list1 = list1.next;
            } else {
                runner.next = list2;
                list2 = list2.next;
            }
            runner = runner.next;
        }

        if(list1 != null) {
            runner.next = list1;
        } else if(list2 != null) {
            runner.next = list2;
        }

        return dummy.next;
    }
}