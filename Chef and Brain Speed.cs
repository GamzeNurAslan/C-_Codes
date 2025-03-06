using System;
public class Test{
    public static void Main()
    {
        string [] s=Console.ReadLine().Split(' ');
        int x=int.Parse(s[0]);
        int y=int.Parse(s[1]);
      
      if( y > x){
          Console.WriteLine("YES");
      }else{
          Console.WriteLine("NO");
      }
    }
}

/*In ChefLand, human brain speed is measured in bits per second (bps). Chef has a threshold limit of 
X
X bits per second above which his calculations are prone to errors. If Chef is currently working at 
Y
Y bits per second, is he prone to errors?

If Chef is prone to errors print YES, otherwise print NO.*/
