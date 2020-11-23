using System.Linq;
using System.Text.RegularExpressions;

namespace Tasks
{
    public class Task2
    {
        /*
         * Construa um método que receba uma string contendo um valor e retorne um bool de acordo com a validação:
         * 
         * 3 Letras maiúsculas
         * 4 digitos (0-9)
         * 1 letra minúscula
         * 
         * Exemplos de entradas validas: 
         * 1 - ABC1234a
         * 2 - QAZ0987b
         * 3 - WSX1324c
         * 
         * Exemplos de entradas inválidas: 
         * 1 - ABC-1234
         * 2 - QAZ1987
         * 3 - abc1324
         * 4 - az111W
         */
        public static bool CheckInput(string input)
        {

            int upcase = 0;
            int lowcase = 0;
            int num = 0;
            bool result = false;


            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch >= 'A' && ch <= 'Z')
                    upcase++;
                else if (ch >= 'a' && ch <= 'z')
                    lowcase++;
                else if (ch >= '0' && ch <= '9')
                    num++;
                if (upcase >= 3)
                {
                    if (lowcase >= 1)
                    {
                        if (num >= 4)
                        {
                            result = true;
                        }
                    }
                }
                else
                    result = false;
            }return result;
        }
    }
}


    

