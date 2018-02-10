using System;

namespace linked_list {
    class Program {
        static void Main (string[] args) {
            int operationChoice = 0;

            Console.WriteLine ("Please choose the type of linked list: ");
            Console.WriteLine ("1. Singly Linked List");
            Console.WriteLine ("2. Doubly Linked List");
            Console.WriteLine ("3. Circular linked list");
            Console.WriteLine (Constants.choicePromptText);
            try {
                int typeChoice = int.Parse (Console.ReadLine ());
                int type = 1;
                do {
                    Console.WriteLine (Constants.menuTitle);
                    switch (typeChoice) {
                        case (int) Types.SINGLY_LINKED_LIST:
                            Console.WriteLine (Constants.singlyLLOperation1);
                            Console.WriteLine (Constants.singlyLLOperation2);
                            Console.WriteLine (Constants.singlyLLOperation3);
                            Console.WriteLine (Constants.singlyLLOperation4);
                            Console.WriteLine (Constants.singlyLLOperation5);
                            Console.WriteLine (Constants.singlyLLOperation6);
                            Console.WriteLine (Constants.choicePromptText);
                            type = (int) Types.SINGLY_LINKED_LIST;
                            break;
                        case (int) Types.DOUBLY_LINKED_LIST:
                            Console.WriteLine (Constants.doublyLLOperation1);
                            Console.WriteLine (Constants.doublyLLOperation2);
                            Console.WriteLine (Constants.doublyLLOperation3); 
                            Console.WriteLine (Constants.doublyLLOperation4);
                            Console.WriteLine (Constants.doublyLLOperation5);
                            Console.WriteLine (Constants.doublyLLOperation6); 
                            type = (int) Types.DOUBLY_LINKED_LIST;
                            break;
                        case (int) Types.CIRCULAR_LINKED_LIST:
                            Console.WriteLine (Constants.circularLLOperation1); 
                            Console.WriteLine (Constants.circularLLOperation2);
                            Console.WriteLine (Constants.circularLLOperation3);
                            Console.WriteLine (Constants.circularLLOperation4); 
                            type = (int) Types.CIRCULAR_LINKED_LIST;
                            break;    
                        default:
                            type = 0;
                            throw new Exception ("Invalid Choice.");
                    }
                    try {
                        operationChoice = int.Parse (Console.ReadLine ());
                        Choice.ExecuteOpertion (operationChoice, type);
                        Console.WriteLine (Constants.operationCompletePrompt + "\n");
                    } catch (Exception e) {
                        Console.WriteLine (e.Message);
                    }
                } while (operationChoice != 0);
            } catch (Exception e) {
                Console.WriteLine (e.Message);
            }
        }
    }
}