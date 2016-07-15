using System;
using System.Threading;

namespace Chapter1Example5 {

    // Usando o ThreadStatic atributo
    internal class Program {

        // Indica que este valor (da prop estática) é única para cada thread
        [ThreadStatic]
        public static int _field;

        private static void Main(string[] args) {
            new Thread(() => {
                for (int x = 0; x < 10; x++) {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                }
            }).Start();

            new Thread(() => {
                for (int x = 0; x < 10; x++) {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }).Start();

            Console.Read();
        }
    }
}