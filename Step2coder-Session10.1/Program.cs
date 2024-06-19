using System;
using System.Threading;

namespace Step2coder_Session10._1
{
    internal class Program
    {
        private static Mutex m1 = new Mutex();

        public static void donothingspecial()
        {
            // simulieren von MUTEX absichern dass man auf eine datei nicht schreibt und liest gleichzeitig..
            //loese mittels mutex und C#
            //ueberblick ueber die  methoden in mutex..

            m1.WaitOne(1000); // nur auf eine ressource zugreifen..
            //

            // hier kommt rein was die funktion macht 

            m1.ReleaseMutex();


        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(donothingspecial));
            Thread t2 = new Thread(new ThreadStart(donothingspecial));

        }
    }
}
