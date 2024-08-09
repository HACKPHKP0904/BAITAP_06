using System;
using System.Collections.Generic;
using XuLI_GENERAY;  // Thêm dòng này để tham chiếu đến namespace chứa MyStack<T>

namespace Result_Generayy
{
    public class Class1
    {
        public void KiemTraIntStack()
        {
            XuLI_GENERAY.Class1.MyStack<int> intStack = new XuLI_GENERAY.Class1.MyStack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            Console.WriteLine("Peek: " + intStack.Peek()); // 3
            Console.WriteLine("Pop: " + intStack.Pop());   // 3
            Console.WriteLine("Pop: " + intStack.Pop());   // 2
        }

        public void KiemTraStringStack()
        {
            XuLI_GENERAY.Class1.MyStack<string> stringStack = new XuLI_GENERAY.Class1.MyStack<string>();
            stringStack.Push("A");
            stringStack.Push("B");
            stringStack.Push("C");
            Console.WriteLine("Peek: " + stringStack.Peek()); // C
            Console.WriteLine("Pop: " + stringStack.Pop());   // C
            Console.WriteLine("Pop: " + stringStack.Pop());   // B
        }

        public void KiemTraStackRong()
        {
            XuLI_GENERAY.Class1.MyStack<string> stringStack = new XuLI_GENERAY.Class1.MyStack<string>();
            Console.WriteLine("Is Empty: " + stringStack.IsEmpty()); // True
        }
    }
}
