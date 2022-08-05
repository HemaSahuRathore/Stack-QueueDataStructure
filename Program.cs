namespace StackNQueueDataStructure
{ /// <summary>
  ///UC 4 : Ability to dequeue from the beginning
  /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;

            Console.WriteLine("Welcome to Stack & Queue Data Structure"); //display welcome msg
            do
            {

                Console.WriteLine("Please select the Options from Below: ");
                Console.WriteLine("1.Ability to create a Stack of 56->30->70");
                Console.WriteLine("2.Ability to peak and pop from the Stack till it is empty 56->30->70");
                Console.WriteLine("3.Ability to create a Queue of 56->30->70");
                Console.WriteLine("4.Ability to dequeue from the beginning");
                Console.Write("5.Exit  ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Stack stack = new Stack();
                        stack.Push(56);
                        stack.Push(30);
                        stack.Push(70);
                        stack.Display();
                        Console.WriteLine();
                        break;
                    case 2:
                        Stack stackObj = new Stack();
                        stackObj.Push(56);
                        stackObj.Push(30);
                        stackObj.Push(70);
                        Console.WriteLine("Is stack Empty : " + stackObj.IsEmpty());
                        Console.WriteLine();
                        break;
                    case 3:
                        Queue queue = new Queue();
                        queue.Enqueue(56);
                        queue.Enqueue(30);
                        queue.Enqueue(70);
                        queue.Display();
                        Console.WriteLine();
                        break;
                    case 4:
                        Queue queueObj = new Queue();
                        queueObj.Enqueue(56);
                        queueObj.Enqueue(30);
                        queueObj.Enqueue(70);
                        queueObj.Display();
                        queueObj.Dequeue();
                        queueObj.Display();
                        Console.WriteLine();
                        break;

                }

            } while (option != 5);

        }
    }
}