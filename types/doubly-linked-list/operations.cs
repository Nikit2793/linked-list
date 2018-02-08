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
            DoublyListNode newNode = CreateNode (data);
            if (head == null) {
                head = newNode;
            } else {
                DoublyListNode node = head;
                while (node.next != null) {
                    node = node.next;
                }
                node.next = newNode;
                newNode.prev = node;
            }
            PrintList (head);
        }

        public static void InsertNodeAtPosition (int data, int position) {
            // position is the new index of the node after insertion in the list
            if (head == null) {
                if (position == 0) {
                    head = CreateNode (data);
                } else {
                    throw new Exception ("Position does not exist in the linked list.");
                }
            } else {
                int listSize = GetListSize ();
                if (position < 0 || position >= listSize) {
                    throw new Exception ("Position does not exist in the linked list");
                }
                DoublyListNode newNode = CreateNode (data);
                if (position == 0) {
                    newNode.next = head;
                    head.prev = newNode;
                    head = newNode;
                } else {
                    DoublyListNode node = head, prev = head;
                    int index = 0;
                    while (position != index && node.next != null) {
                        prev = node;
                        node = node.next;
                        index++;
                    }
                    newNode.prev = prev;
                    newNode.next = node;
                    node.prev = newNode;
                    prev.next = newNode;
                }
            }
            PrintList (head);
        }

        public static void DeleteNodeAtEnd () {
            if (head == null) {
                // no element case
                throw new Exception ("Linked list is empty.");
            } else if (head.next == null) {
                // one element case
                head = null;
            } else {
                // general case
                DoublyListNode node = head, prev = node;
                while (node.next != null) {
                    prev = node;
                    node = node.next;
                }
                node.prev = null;
                prev.next = null;
            }
            PrintList (head);
        }

        public static void DeleteNodeAtBeginning () {
            if (head == null) {
                throw new Exception ("Linked list is empty.");
            } else {
                if (head.next == null) {
                    head = null;
                } else {
                    DoublyListNode node = head.next;
                    head.next = null;
                    node.prev = null;
                    head = node;
                }
            }
            PrintList (head);
        }

        public static void DeleteNodeAtPosition (int position) {
            if (head == null) {
                // linked list is empty
                throw new Exception ("the linked list is empty.");
            } else if (position < 0 || position >= GetListSize ()) {
                // invalid position case
                throw new Exception ("Position is invalid.");
            } else if (head.next == null) {
                // one element case
                head = null;
            } else if (position == 0) { 
                // generic case - position 0
                DoublyListNode node = head.next;
                head.next = null;
                node.prev = null;
                head = node;
            } else {
                // general case
                DoublyListNode node = head, prev = head;
                int index = 0;
                while (position != index && node.next != null) {
                    prev = node;
                    node = node.next;
                    index++;
                }
                prev.next = null;
                node.prev = null;
            }
            PrintList(head);
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
            int length = 0;
            if (head == null) {
                return length;
            } else {
                DoublyListNode node = head;
                while (node.next != null) {
                    node = node.next;
                    length++;
                }
                return length + 1;
            }
        }
    }
}