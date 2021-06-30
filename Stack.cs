using System;
using System.Collections;

namespace StackProject
{
    public class Stack
    {
        private ArrayList stack = new ArrayList();

        public object Obj { get; set; }

        public void Push(object obj)
        {
            Obj = obj; //tentar os dois no parâmetro do métod que empurra para a stack
            PushIntoStack(Obj);
        }

        private void PushIntoStack(object Obj)
        {
            if (Obj != null) stack.Add(Obj);
            else System.Console.WriteLine("InvalidOperationException: null object can not be stacked");
        }

        public object Pop()
        {
            return PopFromTheStack();
        }

        private object PopFromTheStack()
        {
            if (stack.Count > 0)
            {
                var x = stack[stack.Count-1];
                stack.RemoveAt(stack.Count - 1);// (count--);
                //Type T = x.GetType();
                //if (T == typeof(int)) return (int)x;
                //else if (T == typeof(float)) return (float)x;
                //else if (T == typeof(string)) return (string)x;
                //else if (T == typeof(bool)) return (bool)x;
                //else if (T == typeof(System.DateTime)) return (System.DateTime)x;
                //else return T;
                return x; //it looks like it is not necessary casting during unboxing
            }
            else return "Cannot Pop, Stack is empty";
        }

        public void Clear()
        { 
            ClearStack();
        }

        private void ClearStack()
        {
            while (stack.Count > 0) stack.RemoveAt(stack.Count-1);
            //while (count >= 0) stack.RemoveAt(count--);
            Console.WriteLine("\n\n**** Stack was cleared ****\n\n\n");
        
        }
    }
}