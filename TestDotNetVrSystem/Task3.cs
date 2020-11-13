using System.Collections.Generic;

namespace TestDotNetVrSystem
{
    public class Task3
    {
        /*
         * Dada a lista de inteiros, retorne o somatório de todos os itens com valor POSITIVO da lista     
         * LEMBRANDO que 0 (zero) NÃO é um número positivo
         */
        public static int GetSum(List<int> list)
        {
            int sum = 0;
            int i;

            for (i=0; i< list.Count; i++) {
                if (list[i] > 0) sum+= list[i];
            }

            return sum;
        }
    }
}
