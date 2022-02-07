namespace POO2.Src.Entities
{
    public class Moto : Veiculo
    {
        public int Cilindrada { get; set; }
        public Moto(string Marca, string Modelo, string Cor, int Ano, double Preco, int Cilindrada) : base(Marca, Modelo, Cor, Ano, Preco)
        {
            this.Cilindrada = Cilindrada;
        }
        public virtual double Taxa(){
            if(this.Preco >= 14000){
                return this.Preco * 1.3;
            }
            return this.Preco;
        }
        public override string ToString(){
            return "Moto: " + this.Marca + "\n"
            + "Modelo " + this.Modelo + "\n"
            + "Ano " + this.Ano + "\n"
            + "Preco " + Taxa() + "\n"
            + "Cilindrada " + this.Cilindrada + "\n"
            + "Quilometragem " + this.KmRodados;
        }
    }
}