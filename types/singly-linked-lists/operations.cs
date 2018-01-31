using System;

namespace linked_list {
    /// <summary>
    /// Basic operations on singly linked list
    /// Creation of list
    /// Insertion at the beginning
    /// Insertion at the end
    /// Insertion at position p (assuming the new position is p)
    /// Deletion at the beggining
    /// Deletion at the end
    /// Deletion at position p
    /// Deletion of the list
    /// </summary>
    public static class Operations {

        // to keep track of the head
        public static ListNode head = null;

        public static ListNode CreateNode (int data) {
            ListNode node = new ListNode ();
            node.Data = data;
            node.Next = null;
            return node;
        }

        public static void InsertNodeAtBeginning (int data) {
            if (head == null) {
                head = CreateNode (data);
                PrintList (head);
            } else {
                ListNode newNode = CreateNode (data);
                newNode.Next = head;
                head = newNode;
                PrintList (newNode);
            }
        }

        public static void InsertNodeAtEnd (ListNode head) {
            return;
        }

        public static void InsertNodeAtPosition (ListNode head, int position) {
            return;
        }

        public static void DeleteNodeAtEnd () {
            return;
        }

        public static void DeleteNodeAtBeginning () {
            return;
        }

        public static void DeleteList () {
            return;
        }

        public static void PrintList (ListNode head) {
            ListNode node = head;
            Console.WriteLine (Constants.resultPromptText);
            while (node.Next != null) {
                Console.Write ("| " + node.Data + " |-->");
                node = node.Next;
            }
            Console.WriteLine ("| " + node.Data + " |-->X");
            Console.WriteLine ();
        }

        public static void GetListSize (ListNode node) {
            return;
        }
    }
}