using System;
using ExercicioEcoville.Model;
using ExercicioEcoville.ValidationCPF;
using System.Collections.Generic;

namespace ExercicioEcoville
{
    class Program
    {
        static void Main(string[] args)
        {


            ClasseDeModelo CM = new ClasseDeModelo();
            ValidationCPFS VC = new ValidationCPFS();

            HashSet<string> A = new HashSet<string>();

            string op;
            string opcao = "S";
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

                switch (op)
                {
                    case "1":
                        Console.WriteLine("Digite o nome, por favor!");
                        CM.nome = Console.ReadLine();

                        Console.WriteLine("Digite o cpf, por favor!");
                        CM.cpf = Console.ReadLine();


                        if ((VC.Valida(CM.cpf) == true) && (!A.Contains(CM.cpf)))
                        {

                            Console.WriteLine("CPF VÁLIDO!");
                            A.Add(CM.cpf);

                        }
                        else
                        {
                            Console.WriteLine("CPF INVÁLIDO OU JÁ EXISTENTE NA BASE DE DADOS!");
                            VC.Valida(CM.cpf).Equals(false);

                            while (VC.Valida(CM.cpf).Equals(false) && (A.Contains(CM.cpf)))
                            {
                                Console.WriteLine("Digite o cpf novamente, por favor!");
                                CM.cpf = Console.ReadLine();
                                VC.Valida(CM.cpf);
                            }

                        }
                        Console.WriteLine("Deseja sair? [S/N]");
                        opcao = Console.ReadLine();
                        if (opcao.Equals("S") || opcao.Equals("s"))
                        {
                            Environment.Exit(1);
                        }
                        break;

                    case "2":

                        if (A != null) 
                        {

                            foreach (var item in A)
                            {
                                Console.WriteLine("Os seguintes CPF's estão cadastrados: \n");
                                Console.WriteLine(item);

                                Console.WriteLine("Deseja sair? [S/N]");
                                opcao = Console.ReadLine();
                                if (opcao.Equals("S") || opcao.Equals("s"))
                                {
                                    Environment.Exit(1);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Esse Array está vazio!");
                        }

                        break;

                    default:
                        Console.WriteLine("Encerrando a aplicação...");
                        Environment.Exit(0);
                        break;
                }
            } while (!opcao.Equals("N") || !opcao.Equals("n"));
            }
            }
    }

