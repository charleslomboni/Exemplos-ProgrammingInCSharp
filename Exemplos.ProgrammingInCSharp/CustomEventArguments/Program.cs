using System;
using System.Security.Policy;

namespace CustomEventArguments {

    public class MyArgs : EventArgs {

        public MyArgs(int value) {
            Value = value;
        }

        public int Value { get; set; }
    }

    public class Pub {

        /// <summary>
        /// Especifica o tipo do evento
        /// </summary>
        public event EventHandler<MyArgs> OnChange = delegate { }; // Usando as chaves, ele está "instanciado"

        public void Raise() {
            OnChange(this, new MyArgs(42));
        }
    }

    internal class Program {

        private static void Main(string[] args) {
            var p = new Pub();

            p.OnChange += (sender, e) => Console.WriteLine($"Event raised {e.Value}");
            p.Raise();
        }
    }
}