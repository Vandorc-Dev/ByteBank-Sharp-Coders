namespace ByteBank
{
    public class Program
    {
        //Menu
        static void ShowMenu()
        {
            Console.WriteLine("1 - Inserir novo usuário");
            Console.WriteLine("2 - Deletar um usuário");
            Console.WriteLine("3 - Listar todas as contas registradas");
            Console.WriteLine("4 - Detalhes de um usuário");
            Console.WriteLine("5 - Inserir novo usuário");
            Console.WriteLine("0 - Para sair");
            Console.Write("Digite a opção desejada: ");
        }

        static void RegistrarNovoUsuario(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            Console.WriteLine("Digite o cpf: ");
            cpfs.Add(Console.ReadLine());
            Console.WriteLine("Digite o nome: ");
            titulares.Add(Console.ReadLine());
            saldos.Add(0);
        }

        static void ListarTodasAsContas(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            for(int i = 0; i < cpfs.Count; i++)
            {
                Console.WriteLine($"CPF = {cpfs[i]} | Titular = {titulares[i]} | Saldo = R${saldos[i]:F2}");
            }
        }
        public static void Main(string[] args) {

            Console.WriteLine("Antes de de começar a usar, vamos configurar alguns valores.");


            //dados
            List<string> cpfs = new List<string>();
            List<string> titulares = new List<string>();
            List<double> saldos = new List<double>();


            int option;

            do
            {
                ShowMenu();
                option = int.Parse(Console.ReadLine());

                Console.WriteLine("-----------------------");

                switch (option)
                {
                    case 0: Console.WriteLine("Encerrando programa!");
                        break;
                    case 1:
                        RegistrarNovoUsuario(cpfs, titulares, saldos);
                        break;
                    case 2: Console.WriteLine("Faz o que é pedido na opção 2");
                        break;
                    case 3:
                        ListarTodasAsContas(cpfs, titulares, saldos);
                        break;
                }

                Console.WriteLine("-----------------------");


            } while (option != 0);
        }

    }
}
