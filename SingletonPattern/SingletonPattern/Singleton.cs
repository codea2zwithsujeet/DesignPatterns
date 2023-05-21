//The Singleton design pattern is a creational design pattern that ensures a
//class has only one instance and provides a global point of access to it.
namespace SingletonPattern
{
    //The class Singleton is declared as sealed to prevent inheritance.
    //This ensures that no other class can inherit from the Singleton class and
    //create additional instances.
    public sealed class Singleton
    {
        private static Singleton instance;
        private static readonly object lockObject = new object();
        private string someData;

        // Private constructor to prevent instantiation from outside the class
        private Singleton()
        {
        }

        //The instance variable is declared as static.
        //This means it belongs to the class itself rather than an instance of the class.
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    //The lockObject is used to synchronize access to the instance creation code,
                    //ensuring thread safety in a multi-threaded environment.
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }

        // Other members and methods of the Singleton class can be added below
        public string SomeData
        {
            get { return someData; }
            set { someData = value; }
        }

        public void SomeMethod()
        {
            // Method implementation
        }
    }

}
