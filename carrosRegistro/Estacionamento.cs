using System;

namespace carrosRegistro
{
    internal class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora+= precoHora;

        }
        public void adicionarVeiculo()
        {
            Console.Write("Digite a placa do veiculo: ");
            string placa = Console.ReadLine();

            if(veiculos.Any(x => x.Equals(placa.ToUpper())))
            {
                Console.WriteLine("Já existe um veículo com essa placa.");
            }
            else
            {
                veiculos.Add(placa.ToUpper());
                Console.WriteLine("Veículo cadastrado com sucesso");
            }
        }
        public void removerVeiculo()
        {
            Console.Write("Digite a placa que deseja remover: ");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo ficou");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal precoTotal = precoInicial + precoHora * horas;
                veiculos.Remove(placa.ToUpper());
                Console.WriteLine($"O veículo de '{placa.ToUpper()}' foi removido e deve pagar: {precoTotal} reais");

            }

            else
            {
                Console.WriteLine("O veiculo não foi encontrado! :( ");

            }
        }
        public void listaVeiculo()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veiculos adicionados foi: ");
                foreach (var v in veiculos)
                {
                    Console.WriteLine(v);
                }
                    

            }
            else
            {
                Console.WriteLine("Não existe veículos no estacionamento");
            }

        }

        /*public override string ToString()
        {
            return $"";
        }
        */
        //Daria pra por aqui uma listinha de informações:
        //Veiulos adicionados: 
        
    }
}
