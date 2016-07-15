using System;
using System.Threading;

namespace Chapter1Example7 {

    // Enfilando alguns trabalhos na thread pool
    internal class Program {

        private static void Main(string[] args) {
            ThreadPool.QueueUserWorkItem((s) => {
                Console.WriteLine("Working on a thread from threadpool");
            });

            Console.ReadLine();
        }
    }
}