using System;
using System.Collections.Generic;

namespace ExercicioEcoville.Model
{
    public class ProdutoClass
    {
        public string nome { get; set; }
        public double preco { get; set; }
        public int quantidade { get; set; }
        public HashSet<string> vetorDeProduto { get; set; }
    }
}
