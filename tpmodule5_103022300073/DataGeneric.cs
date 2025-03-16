// See https://aka.ms/new-console-template for more information
using System;
public class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }

    // Method untuk mencetak data
    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + this.data);
    }
}

class Program
{
    static void Main()
    {
        // Menggunakan DataGeneric dengan tipe string untuk menyimpan NIM
        DataGeneric<string> nimData = new DataGeneric<string>("103022300073");
        nimData.PrintData();
    }
}