namespace LeetCode.Game;

public partial class Puzzles
{
    public static ListNode SortListNode(ListNode head)
    {
        if (head is null) return null;
        
        // i know this is terrible
        List<int> list = new List<int>();
        
        while (true) // lol
        {
            list.Add(head.val);
            if (head.next is not null) head = head.next;
            else break;
        }
        
        list.Sort();
        
        ListNode sorted = null;
        ListNode sortedHead = null;
        foreach (var t in list)
        {
            if (sorted is null)
            {
                sorted = new ListNode(t);
                sortedHead = sorted;
            }
            else
            {
                var node = new ListNode(t);
                sorted.next = node;
                sorted = sorted.next;
            }
        }
        
        return sortedHead;
    }
    
    public class ListNode(int val = 0, ListNode next = null)
    {
        public int val = val;
        public ListNode? next = next;

        public override bool Equals(object? obj)
        {
            if (obj is not ListNode) return false;

            var node = (ListNode)obj;
            var head = this;
            
            while (null != head.next)
            {
                if (head.val != node.val) return false;
                head = head.next;
                if (null == node.next) return false;
                node = node.next;
            }
            
            return (head.val == node.val) && (null == node.next);
        }
        
        public int[] ToArray()
        {            
            List<int> values = new List<int>();            
            var head = this;
            
            if (head is null) return values.ToArray();
            
            while (null != head.next)
            {
                values.Add(head.val);
                head = head.next;
            }
            values.Add(head.val);
            
            return values.ToArray();
        }
    }
}