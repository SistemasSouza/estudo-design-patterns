namespace ChainOfResponsability.Middlewares
{
    abstract class Middleware
    {
        private Middleware _next;

        public Middleware LinkWith(Middleware next)
        {
            _next = next;

            return _next;
        }

        public abstract bool Check(string username, string password);

        protected bool CheckNext(string username, string password)
        {
            if (_next == null)
                return true;

            return _next.Check(username, password);
        }
    }


}