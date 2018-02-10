using System;
using doubly_linked_list;
using linked_list;

namespace linked_list {
    public static class Choice {
        public static void ExecuteOpertion (int choice, int type) {
            int offset = 0;
            if (type == (int) Types.SINGLY_LINKED_LIST) {
                offset = 0;
            } else if (type == (int) Types.DOUBLY_LINKED_LIST) {
                offset = 6;
            } else if (type == (int) Types.CIRCULAR_LINKED_LIST) {
                offset = 12;
            }
            choice = choice == 0 ? 0 : choice + offset;
            switch (choice) {
                case 0:
                    Environment.Exit (0);
                    break;
                case 1:
                    try {
                        Console.WriteLine (Constants.dataPromptText);
                        int data = int.Parse (Console.ReadLine ());
                        Operations.InsertNodeAtBeginning (data);
                    } catch (Exception e) {
                        Console.WriteLine (e.Message);
                    }
                    break;
                case 2:
                    try {
                        Console.WriteLine (Constants.dataPromptText);
                        int data = int.Parse (Console.ReadLine ());
                        Operations.InsertNodeAtEnd (data);
                    } catch (Exception e) {
                        Console.WriteLine (e.Message);
                    }
                    break;
                case 3:
                    try {
                        Console.WriteLine (Constants.dataPromptText);
                        int data = int.Parse (Console.ReadLine ());
                        Console.WriteLine (Constants.positionPromptText);
                        int position = int.Parse (Console.ReadLine ());
                        Operations.InsertNodeAtPosition (data, position);
                    } catch (Exception e) {
                        Console.WriteLine (e.Message);
                    }
                    break;
                case 4:
                    Operations.DeleteNodeAtBeginning ();
                    break;
                case 5:
                    Operations.DeleteNodeAtEnd ();
                    break;
                case 6:
                    try {
                        Console.WriteLine (Constants.positionPromptText);
                        int position = int.Parse (Console.ReadLine ());

                        Operations.DeleteNodeAtPosition (position);
                    } catch (Exception e) {
                        Console.WriteLine (e.Message);
                    }
                    break;
                case 7:
                    try {
                        Console.WriteLine (Constants.dataPromptText);
                        int data = int.Parse (Console.ReadLine ());
                        doubly_linked_list.Operations.InsertNodeAtBeginning (data);
                    } catch (Exception e) {
                        Console.WriteLine (e.Message);
                    }
                    break;
                case 8:
                    try {
                        Console.WriteLine (Constants.dataPromptText);
                        int data = int.Parse (Console.ReadLine ());
                        doubly_linked_list.Operations.InsertNodeAtEnd (data);
                    } catch (Exception e) {
                        Console.WriteLine (e.Message);
                    }
                    break;
                case 9:
                    try {
                        Console.WriteLine (Constants.dataPromptText);
                        int data = int.Parse (Console.ReadLine ());
                        Console.WriteLine (Constants.positionPromptText);
                        int position = int.Parse (Console.ReadLine ());
                        doubly_linked_list.Operations.InsertNodeAtPosition (data, position);
                    } catch (Exception e) {
                        Console.WriteLine (e.Message);
                    }
                    break;
                case 10:
                    doubly_linked_list.Operations.DeleteNodeAtBeginning ();
                    break;
                case 11:
                    doubly_linked_list.Operations.DeleteNodeAtEnd ();
                    break;
                case 12:
                    try {
                        Console.WriteLine (Constants.positionPromptText);
                        int position = int.Parse (Console.ReadLine ());

                        doubly_linked_list.Operations.DeleteNodeAtPosition (position);
                    } catch (Exception e) {
                        Console.WriteLine (e.Message);
                    }
                    break;
                case 13:
                    try {
                        Console.WriteLine (Constants.dataPromptText);
                        int data = int.Parse (Console.ReadLine ());
                        circular_linked_list.Operations.InsertNodeAtBeginning (data);
                    } catch (Exception e) {
                        Console.WriteLine (e.Message);
                    }
                    break;
                case 14:
                    try {
                        Console.WriteLine (Constants.dataPromptText);
                        int data = int.Parse (Console.ReadLine ());
                        circular_linked_list.Operations.InsertNodeAtEnd (data);
                    } catch (Exception e) {
                        Console.WriteLine (e.Message);
                    }
                    break;
                case 15:
                    circular_linked_list.Operations.DeleteNodeAtBeginning ();
                    break;
                case 16:
                    circular_linked_list.Operations.DeleteNodeAtEnd ();
                    break;
                default:
                    Console.WriteLine (Constants.invalidChoice);
                    break;
            }

        }
    }
}