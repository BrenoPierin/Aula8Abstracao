using System;

namespace Aula8Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito visa = new CartaoCredito();
            visa.limite = 1200f;
            visa.AumentarLimite(visa.limite, 300f);
            // visa.Pagar(900f);

            System.Console.WriteLine("Digite a data de pagamento");
            visa.data = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("data digitada: "+ visa.data);
            
        }
    }
}
