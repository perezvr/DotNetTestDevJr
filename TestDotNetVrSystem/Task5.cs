﻿namespace TestDotNetVrSystem
{
    public class Task5
    {
        /*
         *Crie um método que receba um inteiro e retorne "impar" caso seja impar e "par" caso seja par
         *Caso o número seja 0 (zero), retorne "zero"
         */
        public static string GetEvenOrOdd(int number)
        {
            if (number == 0) {
                return "zero";
            }
            else if (number % 2 == 0) {
                return "par";
            }
            else {
                return "impar";
            }
        }
    }
}
