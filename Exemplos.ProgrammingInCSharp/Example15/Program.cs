using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Example15 {

    /// <summary>
    /// Usando Task.WaitAny
    /// </summary>
    internal class Program {

        private static void Main(string[] args) {

            // Criando um array de task
            Task<int>[] tasks = new Task<int>[3];

            // Criando a primeira task
            tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });

            // Criando a segunda task
            tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });

            // Criando a terceira task
            tasks[2] = Task.Run(() => { Thread.Sleep(3000); return 3; });

            while (tasks.Length > 0) {

                // Aguarda pelo menos uma thread ser finalizada
                int i = Task.WaitAny(tasks);
                Task<int> completedTask = tasks[i];

                Console.WriteLine(completedTask.Result);

                var temp = tasks.ToList();
                temp.RemoveAt(i);
                tasks = temp.ToArray();

                Console.Read();
            }

        }
    }
}