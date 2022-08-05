namespace StackNQueueDataStructure
{ /// <summary>
  ///UC 2 : Ability to peak and pop from the Stack till it is empty 56->30->70
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
                Console.Write("3.Exit  ");
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


                }
            } while (option != 3);


        }
    }
}