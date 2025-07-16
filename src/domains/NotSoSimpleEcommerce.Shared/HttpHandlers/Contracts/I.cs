using NotSoSimpleEcommerce.Shared.InOut.Responses;
using Refit;

namespace NotSoSimpleEcommerce.Shared.HttpHandlers.Contracts;

public interface IOrderApi
//{
//    [Get("/order/api/request/{id}")]
//    [Headers("Authorization: Bearer")]
//    Task<ApiResponse<OrderResponse>> GetOrderByIdAsync(int id);
//}

{
    [Get("/order/api/request/{id}")]
    [Headers("Authorization: Bearer (token)")]
    Task<ApiResponse<OrderResponse>> GetOrderByIdAsync(int id, [Header("token"), string token]);
}
//codigo incompleto/correcao por usar o Refit
