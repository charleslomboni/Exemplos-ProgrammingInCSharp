using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Example16 {

    /// <summary>
    /// Using ParallelFor and Parallel.Foreach
    /// </summary>
    internal class Program {

        private static void Main(string[] args) {

            Parallel.For(0, 10, i => {
                Console.WriteLine($"For: {i}");
                Thread.Sleep(1000);
            });

            // Gera uma sequência de números inteiros dentro do range configurado
            var numbers = Enumerable.Range(0, 10);

            Parallel.ForEach(numbers, i => {
                Console.WriteLine($"Foreach: {i}");
                Thread.Sleep(1000);
            });

            Console.ReadKey();
            // É possível cancelar o loop usando o objeto ParallelLoopState
            // Podemos usar o Break ou Stop
            // Break => Assegura que toda a iteração que está acontecendo, será finalizada.
            // Stop  => Apenas termina tudo que estiver executando
        }
    }
}