using MediatR;
using NotSoSimpleEcommerce.Shared.InOut.Responses;

namespace NotSoSimpleEcommerce.Order.Domain.Commands;

//2 - Comando de criacao
//aqui estamos usando o MediatR para orquestrar os comandos (IRequest<T>)

public class CreateOrderCommand: IRequest<OrderResponse>
{
    public int Id { get; init; }
    public int ProductId { get; init; }
    public int Quantity { get; init; } 
    public string BoughtBy { get; set; }

    public CreateOrderCommand WithBoughBy(string boughtBy)
    {
        BoughtBy = boughtBy;
        return this;
    }
}
