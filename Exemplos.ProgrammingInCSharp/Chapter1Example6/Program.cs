using System;
using System.Threading;

namespace Chapter1Example6 {

    // Usando ThreadLocal<T>
    internal class Program {

        // Para usar uma variável local
        // Que poderá ser inicializada em cada thread
        // Podemos usar a classe ThreadLocal<T>
        public static ThreadLocal<int> _field = new ThreadLocal<int>(() => {
            return Thread.CurrentThread.ManagedThreadId;
        });

        private static void Main(string[] args) {
            new Thread(() => {
                for (int x = 0; x < _field.Value; x++) {
                    Console.WriteLine("Thread A: {0}", x);
                }
            }).Start();

            new Thread(() => {
                for (int x = 0; x < _field.Value; x++) {
                    Console.WriteLine("Thread B: {0}", x);
                }
            }).Start();

            Console.Read();
        }
    }
}