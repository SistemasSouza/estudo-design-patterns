using System;

namespace Adapter
{
  class Payonner : IPayonnerPayment
  {
    private Token token;
    public Token AuthToken()
    {
      return new Token();
    }

    public void ReceivePayment()
    {
      token = AuthToken();
      Console.WriteLine("Enviando pagamento com payonner");
    }

    public void SendPayment()
    {
      Console.WriteLine("Recebendo pagamento com payonner");
    }
  }
}