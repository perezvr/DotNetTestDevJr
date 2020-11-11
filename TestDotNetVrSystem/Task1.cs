using System.Collections.Generic;

namespace TestDotNetVrSystem
{
    public class Task1
    {
        /*
         * Dada a lista de inteiros, retorne o maior número da lista         
         */
        public static int? GetMax(List<int> list)
        {   int max = 0;
            int i;

            for (i = 0; i < list.Count; i++) {
              if(max < list[i]) max = list[i]; 
            }
            
            return max;
        }
    }
}
