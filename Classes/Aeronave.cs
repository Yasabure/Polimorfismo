namespace Veiculos
{
    public class Aeronave : Veiculo
    {
        public Aeronave
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
            Console.WriteLine("A Aeronave irá decolar");
        }

        public override void Parar()
        {
            Console.WriteLine("A Aeronave Irá Pousar");
        }
    }

}