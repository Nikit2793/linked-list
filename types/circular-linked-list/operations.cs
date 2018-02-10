using System;
using linked_list;
namespace circular_linked_list {
    public static class Operations {
        public static CircularListNode head = null;

        public static CircularListNode CreateNode (int data) {
            CircularListNode node = new CircularListNode ();
            node.data = data;
            node.next = node;
            return node;
        }

        public static void InsertNodeAtBeginning (int data) {
            // if linked list is empty.
            CircularListNode newNode = CreateNode (data);
            if (head == null) {
                head = newNode;
            } else {
                CircularListNode node = head;
                while (node.next != head) {
                    node = node.next;
                }
                node.next = newNode;
                newNode.next = head;
                head = newNode;
            }
            PrintList (head);
        }

        public static void InsertNodeAtEnd (int data) {
            CircularListNode newNode = CreateNode (data);
            if (head == null) {
                head = newNode;
            } else {
                CircularListNode node = head;
                while (node.next != head) {
                    node = node.next;
                }
                node.next = newNode;
                newNode.next = head;
            }
            PrintList (head);
        }

        public static void DeleteNodeAtEnd () {
            if (head == null) {
                throw new Exception ("Linked list is empty");
            } else {
                if (head.next != null) {
                    CircularListNode node = head, prev = head;
                    while (node.next != head) {
                        prev = node;
                        node = node.next;
                    }
                    prev.next = head;
                    node.next = null;
                } else {
                    head = null;
                }
            }
            PrintList (head);
        }

        public static void DeleteNodeAtBeginning () {
            if (head == null) {
                throw new Exception ("Linked list is empty");
            } else {
                if (head.next != head) {
                    CircularListNode newHead = head.next;
                    CircularListNode node = head;
                    while (node.next != head) {
                        node = node.next;
                    }
                    node.next = newHead;
                    head.next = null;
                    head = newHead;
                } else {
                    head = null;
                }
            }
            PrintList (head);
        }

        public static void PrintList (CircularListNode head) {
            if (head == null) {
                throw new Exception ("Linked list is empty");
            } else {
                CircularListNode node = head;
                string formattedList = string.Empty;
                string selfLoop = string.Empty;
                Console.WriteLine (Constants.resultPromptText);
                formattedList += "-> | " + head.data + " |";
                selfLoop += "|____";
                for (int i = 0; i < node.data.ToString ().Length; i++) {
                    selfLoop += "_";
                }
                selfLoop += "__";
                node = node.next;
                while (node != head) {
                    formattedList += "-> | " + node.data + " |";
                    selfLoop += "_____";
                    for (int i = 0; i < node.data.ToString ().Length; i++) {
                        selfLoop += "_";
                    }
                    selfLoop += "__";
                    node = node.next;
                }
                formattedList += "->";
                selfLoop += "_|";
                Console.WriteLine (formattedList);
                Console.WriteLine (selfLoop);
            }
            return;
        }

        public static int GetListSize () {
            return 0;
        }
    }
}