namespace NotSoSimpleEcommerce.Shared.InOut.Requests;
//Ciclo em camadas = 1 - Modelo de entrada (API Layer)
public record OrderRequest(int ProductId, int Quantity);
