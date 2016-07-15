using System;
using System.Threading.Tasks;

namespace Chapter1Example10 {

    // Adicionando uma forma de continuação
    internal class Program {

        private static void Main(string[] args) {
            Task<int> t = Task.Run(() => {
                return 42;
            }).ContinueWith((i) => {
                return i.Result * 2;
            });

            // Imprime o 84
            Console.WriteLine(t.Result);
            Console.Read();
        }
    }
}