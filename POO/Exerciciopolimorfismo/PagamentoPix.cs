namespace Exerciciopolimorfismo
{
    
    public class PagamentoPix : Pagamento
    {
        public float ValorCompra;
        private float desconto = 5;
        public override float CalcularTotal()
        {
            float valorDesconto = ValorCompra / 100 * desconto;

            return ValorCompra = ValorCompra - valorDesconto;
        }
    }
}
