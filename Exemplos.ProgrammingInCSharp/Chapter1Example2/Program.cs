using System;
using System.Threading;

namespace Chapter1Example2 {

    // Usando background thread
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

            // Background setado para TRUE a aplicação existe imediatamente
            // Se for setado como FALSE (cria uma foreground thread)
            // A aplicação imprime 10 vezes a mensagem da ThreadProc
            t.IsBackground = true;
            t.Start();
            Console.Read();
        }
    }
}