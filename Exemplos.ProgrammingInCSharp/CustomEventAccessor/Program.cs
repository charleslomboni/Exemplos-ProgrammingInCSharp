using System;

namespace CustomEventAccessor {

    public class MyArgs : EventArgs {

        public MyArgs(int value) {
            Value = value;
        }

        public int Value { get; set; }
    }

    public class Pub {

        private event EventHandler<MyArgs> onChange = delegate { }; // Usando as chaves, ele está "instânciado"

        public event EventHandler<MyArgs> OnChange {
            add {
                lock (onChange) {
                    onChange += value;
                }
            }
            remove {
                lock (onChange) {
                    onChange -= value;
                }
            }
        }

        public void Raise() {
            onChange(this, new MyArgs(42));
        }
    }

    internal class Program {

        private static void Main(string[] args) {
            var p = new Pub();

            p.OnChange += (sender, e) => Console.WriteLine("Method 1");
            p.OnChange += (sender, e) => Console.WriteLine("Method 2");
            p.Raise();
        }
    }
}