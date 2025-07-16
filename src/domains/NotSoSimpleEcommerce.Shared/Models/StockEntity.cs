namespace NotSoSimpleEcommerce.Shared.Models
{
    public sealed class StockEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public ProductEntity Product { get; set; } //usado para nevegacao entre entidades
                                                   //(o ProductId buscaria na tabela Product) e para
                                                    //gerar modelos de dominio mais ricos.
    }
}
