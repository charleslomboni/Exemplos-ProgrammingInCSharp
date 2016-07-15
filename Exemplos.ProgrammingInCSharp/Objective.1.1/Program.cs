using System;
using System.Threading;

namespace Chapter1Example1 {

    // Criando uma thread com a classe Thread
    internal class Program {

        public static void ThreadMethod() {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("ThreadProc: {0}", i);
                // Sinaliza ao windows que essa thread finalizou
                // E imediatamente muda para a outra thread
                Thread.Sleep(0);
            }
        }

        private static void Main(string[] args) {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 0; i < 4; i++) {
                Console.WriteLine("Main thread: Do some work.");
                // Sinaliza ao windows que essa thread finalizou
                // E imediatamente muda para a outra thread
                Thread.Sleep(0);
            }

            // Aguarda até a outra thread terminar
            t.Join();
            Console.Read();
        }
    }
}