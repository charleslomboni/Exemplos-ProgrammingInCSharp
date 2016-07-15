using System;
using System.Threading.Tasks;

namespace Chapter1Example9 {

    // Usando uma task que retorna valor
    internal class Program {

        private static void Main(string[] args) {

            Task<int> t = Task.Run(() => {
                return 42;
            });

            // Imprime o 42
            Console.WriteLine(t.Result);
            Console.Read();
        }
    }
}