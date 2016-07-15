using System;
using System.Threading;

namespace Chapter1Example3 {

    // Usando ParameterizedThreadStart
    internal class Program {

        public static void ThreadMethod(object o) {
            for (int i = 0; i < (int)o; i++) {
                Console.WriteLine("ThreadProc: {0}", i);
                // Sinaliza ao windows que essa thread finalizou
                // E imediatamente muda para a outra thread
                Thread.Sleep(0);
            }
        }

        private static void Main(string[] args) {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));

            // O parâmetro para a ThreadMethod é passado aqui
            // Para abortar a execução do método, pode-se usar o Thread.Abort
            // Porque esse método é executado por outra thread
            // Porém, isso pode deixar o programa inusável
            // A melhor forma de parar a thread, é usando uma variável compartilhada
            // Entre aplicação e a thread
            t.Start(5);
            // Aguarda até a outra thread terminar
            t.Join();
            Console.Read();
        }
    }
}