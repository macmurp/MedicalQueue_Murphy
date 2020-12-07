using System;

namespace MedicalQueue_Murphy
{
    class Program
    {
        static void Main(string[] args)
        {

            ERQueue queue = new ERQueue();
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("Pick an option by entering a letter:\n");
                Console.WriteLine("(A)dd Patient");
                Console.WriteLine("(P)rocess Current Patient");
                Console.WriteLine("(L)ist All in Queue");
                Console.WriteLine("(Q)uit\n");
                switch (Console.ReadLine().ToUpper())
                {
                    case "A":
                        Console.WriteLine("Enter a name to add:");
                        string n = Console.ReadLine();
                        Console.WriteLine("Enter their priority number:");
                        int p = Convert.ToInt32(Console.ReadLine());
                        Patient patient = new Patient(n, p);
                        queue.EnQueue(patient);
                        Console.WriteLine("You added " + n + " to the queue.");
                        Console.WriteLine("There are currently " + queue.QueueCount() + " patients in the queue.\n");
                        break;
                    case "P":
                        Console.WriteLine("Removed " + queue.DeQueue().Data.Name + " from the queue.");
                        Console.WriteLine("There are currently " + queue.QueueCount() + " patients in the queue.\n");
                        break;
                    case "L":
                        Console.WriteLine("Patients in the current queue:\n");
                        Console.WriteLine(queue.ToString() + "\n");
                        break;
                    case "Q":
                        menu = false;
                        break;
                }
            }
        }
    }
}