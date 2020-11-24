namespace Tasks
{
    public class Task5
    {
        /*
         *Crie um método que receba um inteiro e retorne "impar" caso seja impar e "par" caso seja par
         *Caso o número seja 0 (zero), retorne "zero"
         */
        public static string GetEvenOrOdd(int number)
        {
            string result = "";
            
            if (number % 2 == 0)
            {
                result = ("par");
            }



            if (number % 2 != 0)
            {
                result = ("impar");
            }
            
            if (number == 0)
            {
                result = ("zero");
            }

            return result;
        }
    }
}
