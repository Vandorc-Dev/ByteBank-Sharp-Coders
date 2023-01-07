using System;

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
            Console.WriteLine("6 - Manipular uma conta");
            Console.WriteLine("0 - Para sair");
            Console.Write("Digite a opção desejada: ");
        }

        static void RegistrarNovoUsuario(List<string> cpfs, List<string> titulares, List<double> saldos, List<string> senhas)
        {
            Console.WriteLine("Digite o cpf: ");
            cpfs.Add(Console.ReadLine());
            Console.WriteLine("Digite o nome: ");
            titulares.Add(Console.ReadLine());
            Console.WriteLine("Digite uma senha: ");
            senhas.Add(Console.ReadLine());
            saldos.Add(0);
        }


        static void DeletarUsuario(List<string> cpfs, List<string> titulares, List<double> saldos, List<string> senhas)
        {
            Console.WriteLine("Digite o seu cpf");
            string cpfParaDeletar = Console.ReadLine();
            int indexParaDeletar = cpfs.FindIndex(cpf => cpf == cpfParaDeletar);

            if (indexParaDeletar == -1)
            {
                Console.WriteLine("Não foi possivel deletar este usuário");
                Console.WriteLine("MOTIVO: Conta não encontrada.");

            }

            cpfs.Remove(cpfParaDeletar);
            titulares.RemoveAt(indexParaDeletar);
            senhas.RemoveAt(indexParaDeletar);
            saldos.RemoveAt(indexParaDeletar);

            Console.WriteLine("Conta deletada com sucesso!");
        }
        static void ListarTodasAsContas(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            for(int i = 0; i < cpfs.Count; i++)
            {
                ApresentaConta(i, cpfs, titulares, saldos);
            }
        }
        //Apresentar um usuário específico
        static void ApresentaUsuario(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            Console.WriteLine("Digite o seu cpf");
            string cpfParaApresentar = Console.ReadLine();
            int indexParaApresentar = cpfs.FindIndex(cpf => cpf == cpfParaApresentar);

            if (indexParaApresentar == -1)
            {
                Console.WriteLine("Não foi possivel deletar este usuário");
                Console.WriteLine("MOTIVO: Conta não encontrada.");
            }

            ApresentaConta(indexParaApresentar, cpfs, titulares, saldos);
        }

        //Apresentar saldo
        static void ApresentarSaldoAcumulado(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            Console.WriteLine($"Total acumulado no banco:{saldos.Sum()}");

            //return saldos.Sum(); //.Aggregate(0.0, (x, y) => x + y);
        }

        static void ApresentaConta(int index, List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            Console.WriteLine($"CPF = {cpfs[index]} | Titular = {titulares[index]} | Saldo = R${saldos[index]:F2}");
        }

        public static void Main(string[] args) {

            Console.WriteLine("Antes de de começar a usar, vamos configurar alguns valores.");


            //dados
            List<string> cpfs = new List<string>();
            List<string> titulares = new List<string>();
            List<string> senhas = new List<string>();
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
                        RegistrarNovoUsuario(cpfs, titulares, saldos, senhas);
                        break;
                    case 2: 
                        DeletarUsuario(cpfs, titulares, saldos, senhas);
                        break;
                    case 3:
                        ListarTodasAsContas(cpfs, titulares, saldos);
                        break;
                    case 4:
                        ApresentaUsuario(cpfs, titulares, saldos);
                        break;
                    case 5:
                        Console.WriteLine("Fazer algo");
                        break;
                }

                Console.WriteLine("-----------------------");


            } while (option != 0);
        }

    }
}
