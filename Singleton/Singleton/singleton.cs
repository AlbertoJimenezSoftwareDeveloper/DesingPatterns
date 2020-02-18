
namespace Singleton
{
    public class Singleton
    {
        /// <summary>
        /// static variable type singleton to hold the private instance of singleton
        /// </summary>
        private static Singleton _instance = null;

        //Private Constructor 
        private Singleton()
        {

        }


        //public variable static type singleton
        public static Singleton Instance
        {
            get{

                ///check if exists an instance of Singleton class
                if (_instance == null)
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }

        public string Name;

    }
}
