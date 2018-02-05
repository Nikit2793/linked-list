using System;
using doubly_linked_list;
using linked_list;

namespace linked_list {
    public static class Choice {
        public static void ExecuteOpertion (int choice, int type) {
            int offset = (type == (int) Types.SINGLY_LINKED_LIST) ? 0 : (type == (int) Types.DOUBLY_LINKED_LIST) ? 6 : 0;
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
                default:
                    Console.WriteLine (Constants.invalidChoice);
                    break;
            }

        }
    }
}