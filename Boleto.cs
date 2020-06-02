using System;

namespace Aula8Abstracao
{
    public class Boleto : Paagamento
    {
        public DateTime data_vencimento;
        public string banco_emissor;
        public string codigo_de_barras;


        public string RegistrarNoSistema(){
            return "Boleto registrado";
            
        }
    }
}