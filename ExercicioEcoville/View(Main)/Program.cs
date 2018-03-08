using System;
using ExercicioEcoville.Model;
using ExercicioEcoville.ValidationCPF;
using ExercicioEcoville.ValidationProduct;
using System.Collections.Generic;

namespace ExercicioEcoville
{
    class Program
    {
        static void Main(string[] args)
        {


            ClasseDeModelo CM = new ClasseDeModelo();
            ValidationCPFS VC = new ValidationCPFS();
            VendedorClass vendedor = new VendedorClass();
            ProdutoClass produto = new ProdutoClass();
            ValidarObjetos objeto = new ValidarObjetos();

           
            string op;
          //  string opcao = "S";
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
                        VC.ValidadorCPF(CM.cpf);
                        break;
                    case "2":
                        VC.VerificationArray();
                        break;

                    case "3":
                        Console.WriteLine("Digite o nome do vendedor, por favor!");
                        vendedor.nome = Console.ReadLine();
                        Console.WriteLine("Digite o cpf do vendedor, por favor!");
                        vendedor.cpf = Console.ReadLine();
                        VC.ValidadorCPF(vendedor.cpf);
                       break;

                    case "4":
                        VC.VerificationArrayOfSalesman();
                        break;

                    case "5":
                        Console.WriteLine("Digite o nome do produto, por favor!");
                        produto.nome = Console.ReadLine();
                        Console.WriteLine("Digite o preço do produto, por favor!");
                        produto.preco = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a quantidade do produto, por favor!");
                        produto.quantidade = int.Parse(Console.ReadLine());
                        objeto.ValidandoNomes();
                        break;
                    //case "6":

                    //    if (produto.vetorDeProduto != null)
                    //    {

                    //        foreach (var item in produto.vetorDeProduto)
                    //        {
                    //            Console.WriteLine("Os seguintes Produtos estão cadastrados: \n");
                    //            Console.WriteLine(item);

                    //            Console.WriteLine("Deseja sair? [S/N]");
                    //            opcao = Console.ReadLine();
                    //            if (opcao.Equals("S") || opcao.Equals("s"))
                    //            {
                    //                Environment.Exit(1);
                    //            }
                    //        }
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("Esse Array está vazio!");
                    //    }

                    //    break;

                    //case "7":
                        //Console.WriteLine("Digite o cpf do cliente, por favor!");
                        //CM.cpf = Console.ReadLine();

                        //Console.WriteLine("Digite o cpf do vendedor, por favor!");
                        //vendedor.cpf = Console.ReadLine();


                        //if ((VC.Valida(CM.cpf) == true) && (CM.vetorDeCliente.Contains(CM.cpf)))
                        //{

                        //    Console.WriteLine("CPF DO CLIENTE É VÁLIDO E ESTÁ CADASTRADO NA BASE!");


                        //}else if((VC.Valida(vendedor.cpf) == true) && (vendedor.vetorDoVendedor.Contains(vendedor.cpf))){

                        //    Console.WriteLine("CPF DO VENDEDOR É VÁLIDO E ESTÁ CADASTRADO NA BASE!");

                        //}
                        //else
                        //{
                        //    Console.WriteLine("CPF INVÁLIDO OU JÁ EXISTENTE NA BASE DE DADOS!");


                        //    while (VC.Valida(vendedor.cpf) == false)
                        //    {
                        //        Console.WriteLine("Digite o cpf novamente, por favor!");
                        //        CM.cpf = Console.ReadLine();
                        //        VC.Valida(vendedor.cpf);
                        //    }

                        //}
                        //Console.WriteLine("Deseja sair? [S/N]");
                        //opcao = Console.ReadLine();
                        //if (opcao.Equals("S") || opcao.Equals("s"))
                        //{
                        //    Environment.Exit(1);
                        //}
                        //break;

                    default:
                        Console.WriteLine("Encerrando a aplicação...");
                        Environment.Exit(0);
                        break;
                }
            } while (!VC.CallBack().Equals("N"));
            }
            }
    }

