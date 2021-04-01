using System;

namespace Adapter
{
  class MercadoPago : IMercadoPagoPayment
  {
    private Token token;

    public Token Autenticar()
    {
      return new Token();
    }

    public void EnviarPagamento()
    {
      token = Autenticar();
      Console.WriteLine("Enviando pagamento com Mercado pago");
    }

    public void ReceberPagamento()
    {
      Console.WriteLine("Recebendo pagamento com Mercado pago");
    }
  }
}