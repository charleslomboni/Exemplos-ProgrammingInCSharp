using System;

namespace UnderstandingDelegates {

    /// <summary>
    /// A delegate is a type that represents references to methods with a particular parameter
    /// list and return type. When you instantiate a delegate, you can associate its instance
    /// with any method with a compatible signature and return type. You can invoke (or call)
    /// the method through the delegate instance.
    ///
    /// Delegates are used to pass methods as arguments to other methods.Event handlers are
    /// nothing more than methods that are invoked through delegates.You create a custom method,
    /// and a class such as a windows control can call your method when a certain event occurs.
    /// </summary>
    internal class Program {

        /// <summary>
        /// Declara o delegate
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public delegate int Calculate(int x, int y);

        public static int Add(int x, int y) {
            return x + y;
        }

        public static int Multiply(int x, int y) {
            return x * y;
        }

        /// <summary>
        /// Usando o delegate
        /// </summary>
        public static void UseDelegate() {
            // Instancia o delegate como sendo um ponteiro para o método ADD
            Calculate calc = Add;
            // Usa o método calc como o método ADD
            Console.WriteLine(calc(3, 4));

            // Delegate recebe o método de multiplicar
            calc = Multiply;
            // Usa o método calc como sendo o método de multiplicar
            Console.WriteLine(calc(3, 4));
        }

        private static void Main(string[] args) {
            UseDelegate();
        }
    }
}