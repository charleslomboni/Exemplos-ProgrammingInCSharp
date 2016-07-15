using System;
using System.Threading.Tasks;

namespace Chapter1Example8 {

    // Começando uma nova task
    internal class Program {

        private static void Main(string[] args) {
            Task t = Task.Run(() => {
                for (int x = 0; x < 100; x++) {
                    Console.Write("*");
                }
            });

            // Aguarda a execução da task
            // Wait é similar ao Join da thread
            t.Wait();
            Console.Read();
        }
    }
}