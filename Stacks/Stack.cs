using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Stacks
{
    public class ArrayStack<T>
    {
        private T[] StackArray;
        public int Count { get; private set; }

        public int Capacity()
        {
            return StackArray.Length;
        }
            
        public ArrayStack()// set it to 10
        {
            StackArray = new T[10];
        }
            
        public void Push(T value)
        {
            Count++;
            if (Count == StackArray.Length)
            {
                Resize();
            }
            
            StackArray[Count]= value;
           
        }
        private void Resize()
        {
            T[] TempArray = new T[StackArray.Length * 2];

            for(int i=0;i<StackArray.Length; i++)
            {
                TempArray[i] = StackArray[i];
            }

            StackArray = TempArray;
        }
        public T Pop()
        {
            if(IsEmpty())
            {
                throw new Exception("Stack is Empty");//throw exception
            }
            Count--;
            return StackArray[Count+1];
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is Empty");//throw exception
            }
            return StackArray[Count];
        }
        public bool IsEmpty()
        {
            return Count == 0; //true if Count=0
        }
      
    }
}
