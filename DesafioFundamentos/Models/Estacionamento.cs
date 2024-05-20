namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        string placa;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

// implementação do método AdicionarVeiculo
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            placa = Console.ReadLine();

            veiculos.Add(placa);

        }
// implementação do método RemoverVeiculo
        public void RemoverVeiculo()
        {
        Console.WriteLine("Digite a placa do veículo para remover:");

        Console.WriteLine("Por favor, digite a placa do veículo:");
        
         placa = Console.ReadLine();
        
        Console.WriteLine("A placa digitada foi: " + placa);

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                string horas;
                horas = Console.ReadLine();
                int horasConvertidasParaInteiro = int.Parse(horas);

                decimal valorTotal = precoInicial + precoPorHora * horasConvertidasParaInteiro; 

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }
// implementação do método ListarVeiculo
        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
        Console.WriteLine("Placas dos veículos cadastrados:");
        foreach (string v in veiculos)
        {
            Console.WriteLine(v);
        }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
