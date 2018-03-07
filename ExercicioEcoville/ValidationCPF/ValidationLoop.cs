using System;

namespace ExercicioEcoville.ValidationCPF
{

    public class ValidationLoop
    {
        ValidationCPFS validate = new ValidationCPFS();
        public bool teste(string cpf)
        {
            while ((validate.ValidadorCPF(cpf)) == false)
            {
                Console.WriteLine("Digite o cpf novamente, por favor!");
                cpf = Console.ReadLine();
                validate.ValidadorCPF(cpf);
            }
            return validate.ValidadorCPF(cpf);
        }
    }
}
