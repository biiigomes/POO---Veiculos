using System;
using POO2.Src.Entities;

namespace POO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo carro = new Veiculo("Honda", "civic", "Preto", 2020, 60000);
            Veiculo carro2 = new Veiculo("Jeep", "Renegate", "Prata", 2009, 60000);
            Moto moto = new Moto("Honda", "cg160", "Branca", 2010, 200000, 160);

            Console.WriteLine(carro);
            Console.WriteLine("--------");
            Console.WriteLine(carro2);
            Console.WriteLine("--------");
            Console.WriteLine(moto);
    }
  }
}
