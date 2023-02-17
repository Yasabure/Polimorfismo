namespace Veiculos
{
    public class Automovel : Veiculo
    {
        public Automovel
        (
            string tipoVeiculo
        ):
        base
        (
            tipoVeiculo
        )
        {}

        public override void Mover()
        {
            Console.WriteLine("O Automovel está acelerando");
        }

        public override void Parar()
        {
            Console.WriteLine("O Automovel está desacelerando");
        }
    }
}