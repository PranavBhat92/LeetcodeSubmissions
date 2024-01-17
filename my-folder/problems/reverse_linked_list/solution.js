/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @return {ListNode}
 */
var reverseList = function(head) {
    if(head == null) return null;
    if(head.next == null) return head;
    let cur = head;
    let after = head.next;
    let later = after.next;

    if(later == null) {
        after.next = head;
        head.next = null;
        return after;
    } else {
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
};