using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Caller_Queue
{
    // Define a class called CallQueue to create the functions of the program
    // Not static because we need multiple instances of it 
    class CallQueue
    {
        static void Main(string[] args)
        {
            // Step 1: Create Queue. First caller in, first caller out.
            Queue<string> CallerQueue = new Queue<string>();

            // Step 2: Create a Linked List to maintain callers. 
            LinkedList<string> CallerPositions = new LinkedList<string>();

            // Step 3: Adding callers to both collections using a loop.
            Console.WriteLine("Enter the callers. Type 'Done' to close");

            // Step 4: Creating a while loop that contiously takes input until it becomes false
            while (true)
            {
                //Collecting the names
                Console.WriteLine("Enter caller identifier"); 
                string caller = Console.ReadLine();

                // requirments to make the condition false | check for condition first then names in case the of hangup
                if (caller.ToLower() == "done")
                {
                    break;  // exits the loop when 'done is types'. Converts to lower in case any combination of upper and lower.
                }
                
                //Adding callers to the Queue and List
                CallerQueue.Enqueue(caller);
                CallerPositions.AddLast(caller);

                Console.WriteLine($"Added {caller} to the Queue"); 
            }

            // Step 5: Display the Queue/List. I choose to dislay the Linked List
            Console.WriteLine("\nThe Queue");
            foreach (string caller in CallerPositions)
            {
                Console.WriteLine(caller); 
            }

            // Step 6: Taking people out of the line, after processing 
            Console.WriteLine("\nRemoving callers in FIFO order:");

            while (CallerQueue.Count > 0)
            {
                // Dequeue the first caller from the Queue (FIFO)
                string removeName = CallerQueue.Dequeue();

                // Remove the same caller from the LinkedList
                CallerPositions.Remove(removeName);

                Console.WriteLine($"{removeName} has been removed from both the queue and the linked list.");
            }

            // Step 7: Display the updated Queue and LinkedList after removal
            Console.WriteLine("\nUpdated Queue contents (should be empty):");
            foreach (string caller in CallerQueue)
            {
                Console.WriteLine(caller);
            }
        }
    }
    class Call
    {
        public int CallId { get; set; }
        public string CallNumber { get; set; }
        public DateTime CallDateTime { get; set; }
    }
}
