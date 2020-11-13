using System.Collections.Generic;
using System;
namespace TestDotNetVrSystem
{
    public class Task6
    {
        /*
         * Dada uma lista de inteiros, crie um método que devolva a proporção de números positos, negativos e zeros, respectivamente.
         * Obs.: Retornar valores com 6 casas decimais
         * Ex.:
         * Entrada:
         * -4 3 -9 0 4 1    
         * Saída: 
         * 0.500000
         * 0.333333
         * 0.166667
         */
        public static List<decimal> GetRatios(List<int> numbers)
        {
            int positiveCount = 0;
            int negativeCount = 0;
            int zeroCount = 0;

            double positiveRatio;
            double negativeRatio;
            double zeroRatio;


            List<decimal> listRatios = new List<decimal>();
            int i;

            int listLength = numbers.Count;

            for (i = 0; i < listLength; i++)
            {
                if (numbers[i] == 0)
                {
                    zeroCount += 1;

                }
                else if (numbers[i] > 0)
                {
                    positiveCount += 1;
                }
                else
                {
                    negativeCount += 1;
                }
            }
        
            positiveRatio = (double) positiveCount / listLength;
            negativeRatio = (double) negativeCount / listLength;
            zeroRatio = (double) zeroCount / listLength;

            listRatios.Add((decimal) Math.Round(positiveRatio, 6));
            listRatios.Add((decimal) Math.Round(negativeRatio, 6));
            listRatios.Add((decimal) Math.Round(zeroRatio, 6));

            return listRatios;

        }
    }
}
