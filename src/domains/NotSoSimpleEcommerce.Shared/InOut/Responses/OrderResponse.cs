using NotSoSimpleEcommerce.Shared.Enums;

namespace NotSoSimpleEcommerce.Shared.InOut.Responses;

//6 - Response
public record OrderResponse
(
    int Id, 
    ProductResponse Product, 
    int Quantity, 
    string BoughtBy,
    OrderStatus StatusId,
    string Status
);


/* Ciclo resumido (API -> Dominio)
 [JSON HTTP Request]
      ↓
OrderRequest (deserializado) - 1 - Modelo de entrada - API Layer
      ↓
.MapToRegisterOrderCommand() - 3 - Conversao/criacao metodo CreateOrderCommand e o retorno New...- Mapping Layer
      ↓
CreateOrderCommand - 2 - Comando de criacao da requisicao - Application Layer
      ↓
MediatR envia para o Handler - 4 - Controller  API Layer (a requisicao e mapeada para o command e enviada pelo MediatR)
      ↓
Negócio executa e retorna resultado - Handle do comando (execucao da criacao do order de resposta (OrderResponse))
      ↓
OrderResponse - Response
      ↓
[JSON HTTP Response]

 */

/*
Um modelo de entrada (atributos) e definido
Em seguida e criado um Command de captura {get} desse objeto para dar uma resposta IRequest<Response>
A extensao usa a classe para mapear para Command para ser manipulado pelo MediatR
O controller usa o MediatR para enviar a Request. Ele pega a Request, mapeia para o Command e envia via MediatR
O handler do MediatR usa o Command para retornar a Response a partir do Command Request retornando a OrderResponse


 */
