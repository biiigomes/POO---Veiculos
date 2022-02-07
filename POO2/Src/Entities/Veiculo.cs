using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO2.Src.Entities
{
    public class Veiculo
    {
        public string Marca {  get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public double Preco{ get; set; }
        public int KmRodados{ get; set; }

        public Veiculo(string Marca, string Modelo, string Cor, int Ano, double Preco)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Ano = Ano;
            this.Cor = Cor;
            this.Preco = Preco;
            this.KmRodados = 0;
        }
        public double Taxa(){
            if (this.Preco >= 60000)
            {
                return this.Preco * 1.1;
            }
            return this.Preco;
        }
        public override string ToString(){
            return "Carro: " + this.Marca + "\n"
            + "Modelo " + this.Modelo + "\n"
            + "Ano " + this.Ano + "\n"
            + "Preco " + Taxa() + "\n"
            + "Quilometragem " + this.KmRodados;
        }
    }
}