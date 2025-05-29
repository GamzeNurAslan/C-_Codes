using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{ }
public class MyStack<T>
    {
        private LinkedList<T> list = new LinkedList<T>();

        public void Push(T item)
        {
            list.AddFirst(item);
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Yığın boştur lo");
            T value = list.First.Value;
            list.RemoveFirst();
            return value;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Yığın boştur lo");
            return list.First.Value;
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }
    }

    public class Program2
    {
        public static void Main(string[] args)
        {
            MyStack<string> st = new MyStack<string>();

            st.Push("Metin: 'Merhaba'");
            st.Push("Metin: 'Merhaba Gamze'");
            st.Push("Metin: 'Merhaba Gamze!!!'");

            Console.WriteLine("Şu anki metin durumu: " + st.Peek());

            Console.WriteLine("\nGeri alınıyor: " + st.Pop());
            Console.WriteLine("Yeni son durum: " + st.Peek());

            st.Push("Metin: 'Selam Gamze!!!'");

            Console.WriteLine("\nSon güncel metin: " + st.Peek());

            Console.WriteLine("\nTüm işlemleri geri al:");
            while (!st.IsEmpty())
            {
                Console.WriteLine("- " + st.Pop());
            }

            Console.WriteLine("\nHer şey geri alındı mı? " + st.IsEmpty());
        }
    }

