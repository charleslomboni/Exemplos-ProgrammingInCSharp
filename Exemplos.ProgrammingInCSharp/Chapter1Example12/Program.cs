using System;
using System.Threading.Tasks;

namespace Chapter1Example12 {

    // Anexando tasks filhas para uma task pai
    internal class Program {

        private static void Main(string[] args) {
            Task<Int32[]> parent = Task.Run(() => {
                var results = new Int32[3];

                // Tasks filhas
                new Task(() => results[0] = 0,
                    TaskCreationOptions.AttachedToParent).Start();

                new Task(() => results[1] = 1,
                    TaskCreationOptions.AttachedToParent).Start();

                new Task(() => results[2] = 2,
                    TaskCreationOptions.AttachedToParent).Start();

                return results;
            });

            // A parentTask finaliza quando todos os filhos estiverem prontos
            var finalTask = parent.ContinueWith(

                // parentTask termina somente após todos os filhos são finalizados
                parentTask => {
                    foreach (int i in parentTask.Result) {
                        Console.WriteLine(i);
                    }
                }
            );

            // finalTask termina somente após parentTask
            // Aguarda apenas um única thread
            finalTask.Wait();
            Console.Read();
        }
    }
}