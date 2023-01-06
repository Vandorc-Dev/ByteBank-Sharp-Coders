namespace ByteBank
{
    public class Program
    {
        //Menu
        static void ShowMenu()
        {
            Console.WriteLine("1 - Inserir novo usuário");
            Console.WriteLine("2 - Deletar um usuário");
            Console.WriteLine("3 - Detalhes de um usuário");
            Console.WriteLine("4 - Inserir novo usuário");
            Console.WriteLine("0 - Para sair");
            Console.Write("Digite a opção desejada: ");
        }
        public static void Main(string[] args) {

            Console.WriteLine("Antes de de começar a usar, vamos configurar alguns valores.");
            Console.WriteLine("Digite a quantidade de usuários: ");
            int quantidadeDeUsuarios = int.Parse(Console.ReadLine());

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
                    case 1: Console.WriteLine("Faz o que é pedido na opção 1");
                        break;
                    case 2: Console.WriteLine("Faz o que é pedido na opção 2");
                        break;
                    case 3:
                        Console.WriteLine("Faz o que é pedido na opção 3");
                        break;
                    case 4:
                        Console.WriteLine("Faz o que é pedido na opção 4");
                        break;
                }

                Console.WriteLine("-----------------------");


            } while (option != 0);
        }
    }
}
