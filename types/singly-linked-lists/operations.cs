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
            } else {
                ListNode newNode = CreateNode (data);
                newNode.Next = head;
                head = newNode;
            }
            PrintList (head);
        }

        public static void InsertNodeAtEnd (int data) {
            if (head == null) {
                head = CreateNode (data);
            } else {
                ListNode newNode = CreateNode (data);
                ListNode node = head;
                while (node.Next != null) {
                    node = node.Next;
                }
                node.Next = newNode;
            }
            PrintList (head);
        }

        public static void InsertNodeAtPosition (int data, int position) {
            // if position is negetive or head = null or position is more than the length
            // then it is invalid
            // assuming that position needs to be one of the positions of th linked list.

            int listSize = GetListSize ();
            if (head == null || position < 0 || position >= listSize) {
                throw new Exception ("Specified position is invalid or does not exist.");
            }
            // position can be 0, at the end or in the middle
            // we can use the above functions, but for now duplicating the code here.
            ListNode newNode = CreateNode (data);
            ListNode node = head, prevNode = head;
            if (position == 0) {
                newNode.Next = head;
                head = newNode;
            } else {
                int pos = 0;
                while (node.Next != null && pos < position) {
                    prevNode = node;
                    node = node.Next;
                    pos++;
                }
                prevNode.Next = newNode;
                newNode.Next = node;
            }
            PrintList (head);
        }

        public static void DeleteNodeAtEnd () {
            if (head == null) {
                throw new Exception ("Linked list is empty");
            }
            if (head.Next == null) {
                head = null;
            } else {
                ListNode prev = head, node = head;
                while (node.Next != null) {
                    prev = node;
                    node = node.Next;
                }
                prev.Next = null;
            }
            PrintList (head);

        }

        public static void DeleteNodeAtBeginning () {
            if (head != null) {
                ListNode temp = head;
                head = temp.Next;
                temp.Next = null;
                PrintList (head);
            } else {
                throw new Exception ("Linked list is empty.");
            }
        }

        public static void DeleteNodeAtPosition (int position) {
            if (head == null) {
                throw new Exception ("Linked list is empty");
            }
            if (position < 0 || position >= GetListSize ()) {
                throw new Exception ("Position is invalid.");
            }
            if (position == 0) {
                ListNode temp = head;
                head = temp.Next;
                temp.Next = null;
            } else {
                int pos = 0;
                ListNode prev = head, node = head;
                while (node.Next != null && pos != position) {
                    prev = node;
                    node = node.Next;
                    pos++;
                }
                if (node.Next == null) {
                    prev.Next = null;
                } else {
                    prev.Next = node.Next;
                    node.Next = null;
                }
            }
            PrintList (head);
        }

        public static void PrintList (ListNode head) {
            if (head == null) {
                throw new Exception ("Linked list is empty");
            }
            ListNode node = head;
            Console.WriteLine (Constants.resultPromptText);
            while (node.Next != null) {
                Console.Write ("| " + node.Data + " |-->");
                node = node.Next;
            }
            Console.WriteLine ("| " + node.Data + " |-->X");
            Console.WriteLine ();
        }

        public static int GetListSize () {
            if (head == null) {
                return 0;
            } else {
                int len = 0;
                ListNode node = head;
                while (node.Next != null) {
                    node = node.Next;
                    len++;
                }
                return len + 1;
            }
        }
    }
}