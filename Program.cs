using System;
using Veiculos;
internal class Program
{
    static void Main(string[] args)
    {
       Veiculo[] veiculo = new Veiculo[2];

       veiculo[0] = new Automovel("Supra");
       veiculo[1] = new Aeronave("Boengi 707");
       MovimentarVeiculo(veiculo[0]);
       MovimentarVeiculo(veiculo[1]);

       static void MovimentarVeiculo(Veiculo veiculo)
       {
        Console.WriteLine(veiculo.Tipo);
        veiculo.Mover();
       }
    }
}