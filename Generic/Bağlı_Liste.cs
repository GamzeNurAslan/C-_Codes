using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class MyLinkedList<T>
    {
        private class Node
        {
            public T Data;
            public Node Next;

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node head;

        public void Add(T data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        public void PrintAll()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }

    public class Program3
    {
        public static void Main(string[] args)
        {
            MyLinkedList<string> ogrenciListesi = new MyLinkedList<string>();

            ogrenciListesi.Add("Gamze");
            ogrenciListesi.Add("Nur");
            ogrenciListesi.Add("Aslan");
            ogrenciListesi.Add("Kaan");

            Console.WriteLine("Öğrenci Listesi:");
            ogrenciListesi.PrintAll();
        }
    }

}
