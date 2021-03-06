﻿using System;
using System.Threading.Tasks;

namespace Exemple17 {

    /// <summary>
    /// Using Parallel.Break
    /// </summary>
    internal class Program {

        private static void Main(string[] args) {

            ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) => {
                if (i == 500) {
                    Console.WriteLine("Breaking loop");
                    loopState.Break();
                }

                return;
            });

            Console.ReadKey();
        }
    }
}