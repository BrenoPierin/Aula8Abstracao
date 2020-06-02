namespace Aula8Abstracao
{
    public class Cartao : Paagamento
    {
        public string bandeira { get; set; }
        public string token { get; set; }
        public int numero { get; set; }
        public string titular { get; set; }
        public string cvv { get; set; }

        public bool ValidarToken(){
            if(token != null){
            return true;
            }else{
                return false;
            }
        }
    }
}