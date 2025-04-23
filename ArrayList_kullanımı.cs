using System;

public class ArrayList
{
    private object[] items; 
    private int count;      
    private int capacity;   

    public ArrayList()
    {
        capacity = 4;
        items = new object[capacity];
        count = 0;
    }

    public int Count
    {
        get { return count; }
    }

    public void Add(object item)
    {
        EnsureCapacity();
        items[count] = item;
        count++;
    }

    public void Insert(int index, object item) 
    {
        if (index < 0 || index > count)
            throw new ArgumentOutOfRangeException("Dizi aralık dışı");

        EnsureCapacity();

        for (int i = count; i > index; i--)
        {
            items[i] = items[i - 1];
        }

        items[index] = item;
        count++;
    }

    public void RemoveAt(int index) 
    {
        if (index < 0 || index >= count)
            throw new ArgumentOutOfRangeException("Dizi aralık dışı");

        for (int i = index; i < count - 1; i++)
        {
            items[i] = items[i + 1];
        }

        items[count - 1] = null;
        count--;
    }

    public object Get(int index) 
    {
        if (index < 0 || index >= count)
            throw new ArgumentOutOfRangeException("Dizi aralık dışı");

        return items[index];
    }

    public override string ToString() 
    {
        if (count == 0) return string.Empty;

        string result = items[0].ToString();

        for (int i = 1; i < count; i++)
        {
            result += ", " + items[i].ToString();
        }

        return result;
    }

    private void EnsureCapacity() // Kapasiteyi kontrol eder, gerekirse 2 katına çıkarır
    {
        if (count >= capacity)
        {
            capacity *= 2;
            object[] newItems = new object[capacity];
            for (int i = 0; i < count; i++)
            {
                newItems[i] = items[i];
            }
            items = newItems;
        }
    }
}
class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();

        list.Add("Elma");
        list.Add("Armut");
        list.Add("Muz");

        list.Insert(1, "Kiraz");

        Console.WriteLine("Liste: " + list.ToString());

        list.RemoveAt(2);

        Console.WriteLine("Yeni Liste: " + list.ToString()); 

        Console.WriteLine("2. eleman: " + list.Get(1)); 

        Console.WriteLine("Toplam Eleman: " + list.Count);
    }
}

