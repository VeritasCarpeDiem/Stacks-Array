
using System;

namespace Stacks
{
    class Program
    {

        static void Main()
        {
            ArrayStack<int> Stack = new ArrayStack<int>();

            Console.WriteLine(Stack.Count);


            Stack.Push(5);

            Console.WriteLine(Stack.Count);

            Console.WriteLine(Stack.Peek());

            Console.WriteLine(Stack.Pop());

            Console.WriteLine(Stack.Count);


            Stack.Push(7);

            Console.WriteLine(Stack.Peek());
            Console.WriteLine(Stack.Count);

            Stack.Pop();
            Stack.Pop();
        }
    }
   
}
