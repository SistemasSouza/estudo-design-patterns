using System;
using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Servers;

namespace ChainOfResponsability
{
    class Program
    {
        private static Server _server;
        static void Init()
        {
            _server = new Server();

            _server.RegisterUser("denyssouza1@hotmail.com", "1234567");

            _server.RegisterUser("username@hotmail.com", "1234567");

            var middleware = new CheckUserMiddleware(_server);

            middleware.LinkWith(new CheckPermissionsMiddleware());

            _server.SetMiddleware(middleware);
        }

        static void Main(string[] args)
        {
            Init();

            bool done;
            do
            {
                Console.WriteLine("Informe seu usuário");
                string username = Console.ReadLine();

                Console.WriteLine("Informe sua senha");
                string password = Console.ReadLine();

                done = _server.LogIn(username, password);

            } while (!done);

            Console.ReadLine();
        }
    }
}
