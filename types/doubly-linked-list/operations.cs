using System;
using linked_list;
namespace doubly_linked_list {
    public static class Operations {
        public static DoublyListNode head = null;

        public static DoublyListNode CreateNode (int data) {
            DoublyListNode node = new DoublyListNode ();
            node.data = data;
            node.prev = null;
            node.next = null;
            return node;
        }

        public static void InsertNodeAtBeginning (int data) {
            // list is empty
            DoublyListNode node = CreateNode (data);
            if (head != null) {
                node.next = head;
                head.prev = node;
            }
            head = node;
            PrintList (head);
        }

        public static void InsertNodeAtEnd (int data) {
            return;
        }

        public static void InsertNodeAtPosition (int data, int position) {
            return;
        }

        public static void DeleteNodeAtEnd () {
            return;
        }

        public static void DeleteNodeAtBeginning () {
            return;
        }

        public static void DeleteNodeAtPosition (int position) {
            return;
        }

        public static void PrintList (DoublyListNode head) {
            if (head != null) {
                DoublyListNode node = head;
                Console.WriteLine (Constants.resultPromptText);
                Console.Write ("X <- | " + head.data + " |");
                node = node.next;
                while (node != null) {
                    Console.Write ("<-> | " + node.data + " |");
                    node = node.next;
                }
                Console.Write ("-> X\n");
            } else {
                throw new Exception ("Linked list is empty");
            }
        }

        public static int GetListSize () {
            return 0;
        }
    }
}