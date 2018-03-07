using System;
using System.Collections.Generic;

namespace ExercicioEcoville.Model
{
    public class VendedorClass
    {
            public string nome { get; set; }
            public string cpf { get; set; }
            public HashSet<string> vetorDoVendedor { get; set; }

    }
}
