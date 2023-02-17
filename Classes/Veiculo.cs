namespace Veiculos
{
    public abstract class Veiculo
    {
        private string tipo;
       public string Tipo
       {
            get { return tipo; }
            set { Tipo = value; }
       }
       public Veiculo(string tipoVeiculo)
       {
        this.tipo = tipoVeiculo;
       }

       public abstract void Mover();

       public abstract void Parar();
       
    }
}