using System;
public class Test{
    public static void Main()
    {
        string [] s=Console.ReadLine().Split(' ');
        int a=int.Parse(s[0]);
        int b=int.Parse(s[1]);
      
     int toplam = a + b + (a * b);
     
     if(toplam == 111){
         Console.WriteLine("YES");
     }else{
         Console.WriteLine("NO");
     }
    }
}


//a+b+(a⋅b)=111
