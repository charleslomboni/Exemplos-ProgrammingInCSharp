using System;

namespace ExceptionRaisingEvent {

    public class Pub {

        public event EventHandler OnChange = delegate { };

        public void Raise() {
            OnChange(this, EventArgs.Empty);
        }
    }

    internal class Program {

        private static void Main(string[] args) {
            var p = new Pub();

            // Executa o primeiro
            p.OnChange += (sender, e) => Console.WriteLine("Subscriber 1 called");
            // Lança a exception e nada mais acontece
            p.OnChange += (sender, e) => { throw new Exception(); };
            // Não é exibida na tela
            p.OnChange += (sender, e) => Console.WriteLine("Subscriber 3 called");

            p.Raise();
        }
    }
}