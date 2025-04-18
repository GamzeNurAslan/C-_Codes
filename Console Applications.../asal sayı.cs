using System;
class Procee{
static void Main(string[] args)
        {
            int kontrol = 0;
            Console.Write("Sayı Girin : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
 
            if(sayi==1 || sayi == 0)
            {
                Console.WriteLine("Girdiğiniz sayı asal değildir.");
                
            }
            else
            {
                for (int i = 2; i < sayi/2; i++)
                {
                    if (sayi % i == 0) //Kalansız bölünüyormu?
                    {
                        kontrol++;
                        break; //Diğer sayılara bakmaya gerek duymuyoruz.
                    }
                        
                    
                }
 
                if (kontrol != 0)
                {
                    Console.WriteLine("Girdiğiniz sayı asal değildir.");
                }
 
                else
                {
                    Console.WriteLine("Girdiğiniz sayı asaldır.");
                }
                    
            }
 
            
            Console.ReadKey();
        }}
