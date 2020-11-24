using System.Collections.Generic;

namespace Tasks
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
        public static List<decimal> GetRatios(List<int> numbers) {
            int i = 0;
            int negnum = 0;
            int zeronum = 0;
            int posnum = 0;
            for (i = 0; i <= numbers.Count; i++)
            {
                if (numbers[i] > 0) 
                 posnum = posnum / negnum / zeronum;
                numbers.Add(posnum);
                if (numbers[i] < 0) 
                negnum = negnum / posnum / zeronum;
                numbers.Add(negnum);
                if (numbers[i] == 0) 
                 zeronum = zeronum / negnum / posnum;
                numbers.Add(zeronum);

            }
            return numbers.ConvertAll(x => (decimal)x);

        }
    }
}
