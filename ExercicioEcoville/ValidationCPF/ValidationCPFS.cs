using System;
using System.Collections.Generic;
using ExercicioEcoville.Model;

namespace ExercicioEcoville.ValidationCPF
{
    public class ValidationCPFS
    {
        
        ClasseDeModelo cliente = new ClasseDeModelo();
        VendedorClass vendedor = new VendedorClass();
        HashSet<string> VetorDeClientes = new HashSet<string>();
        HashSet<string> VetorDeVendedores = new HashSet<string>();
       // int contador = 0;
       

        public bool Valida(string cpf)
        {


            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            string dgsVerificadores;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if ((cpf == "00000000000") ||
                (cpf == "11111111111") ||
                (cpf == "22222222222") ||
                (cpf == "33333333333") ||
                (cpf == "44444444444") ||
                (cpf == "55555555555") ||
                (cpf == "66666666666") ||
                (cpf == "77777777777") ||
                (cpf == "88888888888") ||
                (cpf == "99999999999"))
            {
                return false;
            }
            if (cpf.Length != 11)

                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = resto.ToString();
            dgsVerificadores = digito;
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = resto.ToString();
            dgsVerificadores += digito;

            if (((dgsVerificadores) == cpf.Remove(0, 9)))
            {
                return true;
            }
            return false;
        }

        public void ValidadorCPF(string cpf)
        {

            if ((Valida(cpf) == true) && (!VetorDeClientes.Contains(cpf)))
            {
                Console.WriteLine("CPF VÁLIDO!");
                Console.WriteLine("Qual a sua ocupação??");
                string op = Console.ReadLine();
                switch(op){
                    case "Cliente":
                        VetorDeClientes.Add(cpf);
                        break;

                    case "Vendedores":
                        VetorDeVendedores.Add(cpf);
                        break;

                    default:
                        break;
                }
                return;

            }
            else
            {

                do
                {
                    Console.WriteLine("Erro! Digite o cpf novamente, por favor!");
                    cpf = Console.ReadLine();
                    ValidadorCPF(cpf);

                } while ((Valida(cpf)) == false);
                    
                    
                }
            }

        public string CallBack(){

            Console.WriteLine("Deseja sair? [S/N]");
            string opcao = Console.ReadLine();
            if (opcao.Equals("S") || opcao.Equals("s"))
            {
                Environment.Exit(1);
            }

            return opcao;

        }

        public HashSet<string> VerificationArray(){

            if (VetorDeClientes != null)
            {

            foreach (var item in VetorDeClientes)
            {
                        Console.WriteLine("Os seguintes CPF's dos clientes estão cadastrados: ");
                        Console.WriteLine(item);
                }
            
            
            }else{
                    Console.WriteLine("Esse Array está vazio!");
                }
            return VetorDeClientes;
            }

        public HashSet<string> VerificationArrayOfSalesman()
        {

            if (VetorDeVendedores != null)
            {

                foreach (var item in VetorDeClientes)
                {
                    Console.WriteLine("Os seguintes CPF's dos vendedores estão cadastrados: ");
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Esse Array está vazio!");
            }
            return VetorDeClientes;
        }
            

        }



        }

  









