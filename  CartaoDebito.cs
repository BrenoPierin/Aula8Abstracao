namespace Aula8Abstracao
{
    public class  CartaoDebito : Cartao
    {
        public int saldo { get; set; }

        public bool transferir(float valor){
            return true;
        }

        public bool PagarTitulo(){
            return true;
        }
    }
}