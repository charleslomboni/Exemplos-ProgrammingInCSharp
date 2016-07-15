using System;
using System.Threading;

namespace Chapter1Example4 {

    // Parando a thread
    internal class Program {

        private static void Main(string[] args) {
            var stopped = false;

            Thread t = new Thread(new ThreadStart(() => {
                while (!stopped) {
                    Console.Write("Running...");
                    // Sinaliza ao windows que essa thread finalizou
                    // E imediatamente muda para a outra thread
                    Thread.Sleep(0);
                }
            }));

            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.Read();

            stopped = true;

            // Aguarda até a thread terminar
            t.Join();
        }
    }
}