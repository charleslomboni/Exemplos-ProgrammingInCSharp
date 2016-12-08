using System;

namespace MulticastDelegate {

    internal class Program {

        /// <summary>
        /// Declarando o delegate
        /// </summary>
        public delegate void Del();

        public static void MethodOne() {
            Console.WriteLine("MethodOne");
        }

        public static void MethodTwo() {
            Console.WriteLine("MethodTwo");
        }

        /// <summary>
        /// Multicast delegate
        /// </summary>
        public static void Multicast() {
            // d recebe o método um
            Del d = MethodOne;
            // d adiciona o método dois
            d += MethodTwo;

            // Pega quantos métodos o delegate irá invocar
            var invocationCount = d.GetInvocationList().GetLength(0);

            // Chama o delegate
            d();
        }

        private static void Main(string[] args) {
            Multicast();
        }
    }
}