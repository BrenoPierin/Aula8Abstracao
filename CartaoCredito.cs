namespace Aula8Abstracao
{
    public class CartaoCredito : Cartao
    {
        public float limite { get; set; }
        public int resposta;
        public string AumentarLimite(float limite, float acrecsimo){
            return "Aumentando o limite do cartão para "+(limite + acrecsimo);
        }

        public bool Bloquear(){
            return true;
        }

    }
}