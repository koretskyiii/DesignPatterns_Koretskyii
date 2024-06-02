namespace task3
{
    public  sealed class Authenticator
    {
        private static Authenticator instance = null;
        private static readonly object obj = new object();

        Authenticator()
        {
        }

        public static Authenticator Instance
        {
            get
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new Authenticator();
                    }
                    return instance;
                }
            }
        }
    }
}
