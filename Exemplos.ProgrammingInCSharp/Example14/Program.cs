using System;
using System.Threading;
using System.Threading.Tasks;

namespace Example14 {

    /// <summary>
    /// Usando Task.WaitAll
    /// </summary>
    internal class Program {

        private static void Main(string[] args) {

            // Criando um array de task
            Task[] tasks = new Task[3];

            // Criando a primeira task
            tasks[0] = Task.Run(() => {
                // Espera 1000 milisegundos
                Thread.Sleep(1000);
                Console.WriteLine("1");
                return 1;
            });

            // Criando a segunda task
            tasks[1] = Task.Run(() => {
                // Espera 1000 milisegundos
                Thread.Sleep(1000);
                Console.WriteLine("2");
                return 2;
            });

            // Criando a terceira task
            tasks[2] = Task.Run(() => {
                // Espera 1000 milisegundos
                Thread.Sleep(1000);
                Console.WriteLine("3");
                return 3;
            });

            // Aguarda todas as threads executarem
            Task.WaitAll(tasks);

            Console.Read();
        }
    }
}