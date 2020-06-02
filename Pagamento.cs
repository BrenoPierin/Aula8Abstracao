using System;

namespace Aula8Abstracao
{
    public class Paagamento
    {
        public DateTime data { get; set; }
        public int valor { get; set; }

        public string pagar(float valor){
            return "Pagamneto realizado no valor de R$"+valor;
        }
        public string cancelar(){
        return "compra cancelada";
        }
    }
}