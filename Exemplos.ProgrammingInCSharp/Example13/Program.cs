using System;
using System.Threading.Tasks;

namespace Example13 {

    /// <summary>
    /// Usando taskFactory
    /// </summary>
    public static class Program {

        public static void Main() {
            // Configuração da taskFactory
            Task<Int32[]> parent = Task.Run(() => {
                var results = new Int32[3];

                // Para não precisar criar múltiplas intâncias de nova task como no exemplo12
                // Podemos usar taskFactory
                TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously);

                tf.StartNew(() => results[0] = 0);
                tf.StartNew(() => results[1] = 1);
                tf.StartNew(() => results[2] = 2);

                return results;
            });

            var finalTask = parent.ContinueWith(parentTask => {
                foreach (int i in parentTask.Result) {
                    Console.WriteLine(i);
                }
            });

            // Aguarda a thread
            finalTask.Wait();

            Console.Read();
        }
    }
}