namespace LeetCode.Game;

public partial class Puzzles {
    public static ListNode MergeTwoSortedLists(ListNode list1, ListNode list2)
    {
        if (list1 is null && list2 is null)
        {
            return null;
        }
        
        ListNode newHead = new ListNode();
        ListNode current = newHead;
        
        while (list1 is not null && list2 is not null)
        {            
            if (list1.val <= list2.val)
            {
                current.val = list1.val;
                list1 = list1.next!;
            }
            else
            {
                current.val = list2.val;
                list2 = list2.next!;
            }
            
            current.next = new ListNode();
            current = current.next;
        }
        if (list1 is null)
        {
            while (list2 is not null)
            {               
                current.val = list2.val;
                list2 = list2.next!;
                
                if (list2 is null) break;
            
                current.next = new ListNode();
                current = current.next;
            }
        }
        else if (list2 is null)
        {
            while (list1 is not null)
            {
                current.val = list1.val;
                list1 = list1.next!;
                if (list1 is null) break;
                
                current.next = new ListNode();
                current = current.next;
            }
        }
        
        return newHead;
    }
}