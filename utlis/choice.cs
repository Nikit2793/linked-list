using System;
using linked_list;

namespace linked_list {
    public static class Choice {
        public static void ExecuteOpertion (int choice) {
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
                default:
                    Console.WriteLine (Constants.invalidChoice);
                    break;
            }

        }
    }
}