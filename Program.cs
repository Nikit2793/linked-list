using System;
using linked_list;

namespace linked_list {
    class Program {
        static void Main (string[] args) {
            int choice = 0;
            do {
                Console.WriteLine (Constants.menuTitle);
                Console.WriteLine (Constants.singlyLLOperation1);
                Console.WriteLine (Constants.choicePromptText);
                try {
                    choice = int.Parse (Console.ReadLine ());
                    Choice.ExecuteOpertion (choice);
                    Console.WriteLine (Constants.operationCompletePrompt + "\n");
                } catch (Exception e) {
                    Console.WriteLine (e.Message);
                }
            } while (choice != 0);
        }
    }
}