using System;

namespace StackProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack stack = new Stack();
            
            stack.Push(1);
            stack.Push("this is an object");
            stack.Push(DateTime.Now);
            stack.Push(null);
            
            stack.Clear();

            stack.Push(2);
            stack.Push("this is another object");
            stack.Push(DateTime.Now);
            stack.Push("345");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());


        }
    }
}
