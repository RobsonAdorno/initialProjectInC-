using System;
using ExercicioEcoville.Model;
using ExercicioEcoville.ValidationCPF;

namespace ExercicioEcoville
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasseDeModelo CM = new ClasseDeModelo();
            ValidationCPFS VC = new ValidationCPFS();
            string op;
            string opcao;
            do
            {
                Console.WriteLine("Selecione a opção desejada:");
                Console.WriteLine("=============================");
                Console.WriteLine("1 - Cadastrar Cliente:");
                Console.WriteLine("=============================");
                Console.WriteLine("2 - Listar Clientes:");
                Console.WriteLine("=============================");
                Console.WriteLine("3 - Cadastrar Vendedor:");
                Console.WriteLine("=============================");
                Console.WriteLine("4 - Listar Vendedores:");
                Console.WriteLine("=============================");
                Console.WriteLine("5 - Cadastrar Produtos:");
                Console.WriteLine("=============================");
                Console.WriteLine("6 - Listar Produtos:");
                Console.WriteLine("=============================");
                Console.WriteLine("7 - Registrar Venda:");
                Console.WriteLine("=============================");
                Console.WriteLine("8 - Listar Venda:");
                Console.WriteLine("=============================");
                Console.WriteLine("9 - Listar Vendas por Cliente:");
                Console.WriteLine("=============================");
                Console.WriteLine("0 - Sair:");
                Console.WriteLine("=============================");
                op = Console.ReadLine();
                opcao = "N";

                switch (op)
                {
                    case "1":
                        Console.WriteLine("Digite o nome, por favor!");
                        CM.nome = Console.ReadLine();

                        Console.WriteLine("Digite o cpf, por favor!");
                        CM.cpf = Console.ReadLine();

                            do
                            {
                            if (VC.Valida(CM.cpf) == true)
                            {
                                Console.WriteLine("CPF VÁLIDO!");
                            }
                            else
                            {
                                Console.WriteLine("CPF INVÁLIDO");
                                Console.WriteLine("Digite o cpf novamente, por favor!");
                                CM.cpf = Console.ReadLine();
                            }
                            } while (VC.Valida(CM.cpf) == false);
                            Console.WriteLine("CPF VÁLIDO!");
                            Console.WriteLine("Deseja sair? [S/N]");
                            opcao = Console.ReadLine();
                            if (opcao.Equals("S") || opcao.Equals("s"))
                            {
                                Environment.Exit(1);
                            }

                        break;
                        
                    case "2":
                        Console.WriteLine("Nome do cliente é : " + CM.nome);
                        break;

                    default:
                        Console.WriteLine("Encerrando a aplicação...");
                        Environment.Exit(0);
                        break;
                }


            } while (opcao.Equals("N"));
            Console.WriteLine("\nAperte uma tecla para continuar...");
            Console.ReadKey();

            Console.WriteLine("Selecione a opção desejada:");
            Console.WriteLine("=============================");
            Console.WriteLine("1 - Cadastrar Cliente:");
            Console.WriteLine("=============================");
            Console.WriteLine("2 - Listar Clientes:");
            Console.WriteLine("=============================");
            Console.WriteLine("3 - Cadastrar Vendedor:");
            Console.WriteLine("=============================");
            Console.WriteLine("4 - Listar Vendedores:");
            Console.WriteLine("=============================");
            Console.WriteLine("5 - Cadastrar Produtos:");
            Console.WriteLine("=============================");
            Console.WriteLine("6 - Listar Produtos:");
            Console.WriteLine("=============================");
            Console.WriteLine("7 - Registrar Venda:");
            Console.WriteLine("=============================");
            Console.WriteLine("8 - Listar Venda:");
            Console.WriteLine("=============================");
            Console.WriteLine("9 - Listar Vendas por Cliente:");
            Console.WriteLine("=============================");
            Console.WriteLine("0 - Sair:");
            op = Console.ReadLine();
            opcao = "N";

            switch (op)
            {
                case "1":
                    Console.WriteLine("Digite o nome, por favor!");
                    CM.nome = Console.ReadLine();
                    Console.WriteLine("Digite o cpf, por favor!");
                    CM.cpf = Console.ReadLine();
                    VC.Valida(CM.cpf);
                    Console.WriteLine("Deseja sair? [S/N]");
                    opcao = Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Nome do cliente é : " + CM.nome);
                    break;

                default:
                    Console.WriteLine("Encerrando a aplicação...");
                    Environment.Exit(0);
                    break;
            }

        }
    }
}