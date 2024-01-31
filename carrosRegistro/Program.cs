namespace carrosRegistro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal precoInicial = 0;
            decimal precoHora = 0;

            Console.WriteLine("Seja bem vindo ao Estacionamento Fox ");
            Console.WriteLine("----------------------------------------- ");

            Console.WriteLine("Digite o preço inicial");
            precoInicial = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o preço por hora");
            precoHora = Convert.ToInt32(Console.ReadLine());

            Estacionamento es = new Estacionamento(precoInicial, precoHora);

            bool menu = true;

            while (menu)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1 - Adicionar Veículos");
                Console.WriteLine("2 - Remover Veículos");
                Console.WriteLine("3 - Listar Veículos");
                Console.WriteLine("4 - Sair do sistema");
                switch (Console.ReadLine())
                {
                    case "1":
                        es.adicionarVeiculo();
                        break;

                    case "2":
                        es.removerVeiculo();
                        break;

                    case "3":
                        es.listaVeiculo();
                        break;

                    case "4":
                        menu = false;
                        break;

                    default:
                        Console.WriteLine("Digite um opção válida");
                        break;
                }
                Console.WriteLine("Digite uma tecla pra continuar");
                Console.ReadLine();
            }
            Console.WriteLine("Fim !");
        }
    }
}