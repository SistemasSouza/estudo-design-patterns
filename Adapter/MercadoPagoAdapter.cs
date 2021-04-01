using Adapter;

namespace Adapter
{
  class MercadoPagoAdapter : IPayPalPayment
  {

    private MercadoPago _mercadoPago;
    public MercadoPagoAdapter(MercadoPago mercadoPago)
    {
        _mercadoPago = mercadoPago;
    }
    public Token AuthToken()
    {
      return _mercadoPago.Autenticar();
    }

    public void PayPalPayment()
    {
      _mercadoPago.EnviarPagamento();
    }

    public void PayPalReceive()
    {
       _mercadoPago.ReceberPagamento();
    }
  }
}