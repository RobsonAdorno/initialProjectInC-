using System;
using ExercicioEcoville.Model;
using System.Collections.Generic;

namespace ExercicioEcoville.ValidationProduct
{
    public class ValidarObjetos
    {

        ProdutoClass produto = new ProdutoClass();
        HashSet<string> NomeProduto = new HashSet<string>();
        HashSet<double> PrecoProduto = new HashSet<double>();
        HashSet<int> QTProduto = new HashSet<int>();

        public void ValidandoNomes()
        {
            NomeProduto.Add(produto.nome);


            foreach(var item in NomeProduto){
                Console.WriteLine("Nomes dos produtos: ");
                Console.WriteLine(item);
            }

        }
    }
}
