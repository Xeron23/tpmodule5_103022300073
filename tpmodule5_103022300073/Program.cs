// See https://aka.ms/new-console-template for more information

using tpmodule5_103022300073;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Masukna nama: ");
        string nama = Console.ReadLine();
        HaloGeneric halo = new HaloGeneric();
        halo.sapaUser(nama);
    }
}