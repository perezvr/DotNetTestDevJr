using System.Collections.Generic;
using TestDotNetVrSystem.HelpClasses;
namespace TestDotNetVrSystem
{
    public class Task7
    {
        /*
         * Desenvolma um método que retorne o nome dos produtos que estão com estoque zerado
         * Dica: A classe Repository possui as informções dos Products
         */
        public static List<string> GetProductsOutOfStock()
        {
            int i;
            Repository Repo = new Repository();
            List<string> productsOutofStock = new List<string>();


            for (i = 0; i < Repo.Products.Count; i++)
            {
                if (Repo.Products[i].Stock.Quantity == 0)
                {
                    productsOutofStock.Add(Repo.Products[i].Name);
                }
            }

            return productsOutofStock;
        }



        /*
        * Desenvolma um método que retorne a soma total das quantidades de estoque dos itens
        * Dica: A classe Repository possui as informções dos Products
        */
        public static int GetSumStock()
        {
            int i;
            int sumQuantity = 0;
            Repository Repo = new Repository();


            for (i = 0; i < Repo.Products.Count; i++)
            {
                sumQuantity += Repo.Products[i].Stock.Quantity;
            }


            return sumQuantity;
        }

        /*
         * Crie um método que verifique, dado Id e quantidade solicitada do produto
         * se o mesmo possui quantidade em estoque para venda
         * Dica: A classe Repository possui as informções dos Products
         * 
         */
        public static bool IsSalePossible(int productId, int orderQuantity)
        {
            int i;
            Repository Repo = new Repository();


            for (i = 0; i < Repo.Products.Count; i++)
            {
                if (productId == Repo.Products[i].Id)
                    if (Repo.Products[i].Stock.Quantity >= orderQuantity)
                        {
                            return true;
                        } else
                        {
                            return false;
                        }
            }


            return false;
        }
    }
}
