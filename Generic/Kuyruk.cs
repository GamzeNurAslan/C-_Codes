using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{ 
public class MyQueue<T>
        {
            private LinkedList<T> list = new LinkedList<T>();

            public void Enqueue(T item)
            {
                list.AddLast(item);
            }

            public T Dequeue()
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Kuyruk boş.");
                T value = list.First.Value;
                list.RemoveFirst();
                return value;
            }

            public T Peek()
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Kuyruk boş.");
                return list.First.Value;
            }

            public bool IsEmpty()
            {
                return list.Count == 0;
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                MyQueue<string> bankaSirasi = new MyQueue<string>();

                bankaSirasi.Enqueue("Gamze");
                bankaSirasi.Enqueue("Nur");
                bankaSirasi.Enqueue("Aslan");

                Console.WriteLine("Güncel sıradaki kişi: " + bankaSirasi.Peek());

                Console.WriteLine("İşlem yapılacak müşteri: " + bankaSirasi.Dequeue());

                Console.WriteLine("Yeni sıradaki kişi: " + bankaSirasi.Peek());

                bankaSirasi.Enqueue("Kaan");

                Console.WriteLine("\nTüm kalan müşteriler işleme alınıyor");
                while (!bankaSirasi.IsEmpty())
                {
                    Console.WriteLine("- " + bankaSirasi.Dequeue());
                }

                Console.WriteLine("\nBanka sırası şu an boş mu? " + bankaSirasi.IsEmpty());
            }
        }

    }
