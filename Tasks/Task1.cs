using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
    public class Task1
    {
        /*
         * Dada a lista de inteiros, retorne o maior número da lista         
         */
        public static int? GetMax(List<int> list) {
            var valmax = list.Max();
            return valmax;
        }
    }
}

