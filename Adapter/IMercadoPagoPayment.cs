namespace Adapter
{
    interface IMercadoPagoPayment
    {
      Token Autenticar();
      void EnviarPagamento();     
      void ReceberPagamento();     
    }
}