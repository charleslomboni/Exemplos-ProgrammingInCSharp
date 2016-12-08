using System;

namespace UsingEvents {

    internal class Program {

        public class Pub {
            public Action OnChange { get; set; }

            public void Raise() {
                //if (OnChange != null) {
                //    OnChange();
                //}

                // Mesmo código acima
                OnChange?.Invoke();
            }
        }

        private static void Main(string[] args) {
            // Cria nova instância de Pub
            var p = new Pub();
            // Assina para o evento, dois métodos
            p.OnChange += () => Console.WriteLine("Event raised to method 1");
            p.OnChange += () => Console.WriteLine("Event raised to method 2");

            // Executa o evento
            p.Raise();
        }
    }
}