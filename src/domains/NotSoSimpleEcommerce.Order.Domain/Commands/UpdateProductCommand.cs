using MediatR;
using NotSoSimpleEcommerce.Shared.InOut.Responses;

namespace NotSoSimpleEcommerce.Order.Domain.Commands
    //Este codigo visa carregar os dados de entrada da requisicao
    //O Handler aplica as atualizacoes no banco e monta o OrderResponse
    //O OrderResponse retorna os dados finais da operacao de atualizacao
    //Isso e como se fosse um DTO interno usado pela logica do MediatR
{
    public sealed class UpdateOrderCommand: IRequest<OrderResponse>
    {
        public int Id { get; init; }
        public int ProductId { get; init; }
        public int Quantity { get; init; } 
        public string BoughtBy { get; set; }

        public UpdateOrderCommand WithBoughBy(string boughtBy)
        {
            BoughtBy = boughtBy;
            return this;
        }
    }
}
