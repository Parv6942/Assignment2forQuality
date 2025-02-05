namespace ProductConstructor
{
    public class ProductConstruct
    {
        public int ProdID { get; set; }
        public string? ProdName { get; set; }
        public int ItemPrice { get; set; }
        public int StockAmount { get; set; }

        public ProductConstruct(int prodID, string prodName, int itemPrice, int stockAmount)
        {
            ProdID = prodID;
            ProdName = prodName;
            ItemPrice = itemPrice;
            StockAmount = stockAmount;
        }
        public static string ValidProductId(int prodID)
        {
            string resultId;


            if (prodID >= 5 && prodID <= 50000)
            {
                resultId = "The ProdID is valid";
            }
            else
            {
                resultId = "The ProdID is not valid";
            }
            return resultId;        
        }

        public static string? ValidProductName(string prodName)
        {
            string resultName;


            if (prodName == "Test Product")
            {
                resultName = "The ProdName is valid";
            }
            else
            {
                resultName = "The ProdName is not valid";
            }
            return resultName;
        }

        public static string ValidProductPrice(int itemPrice)
        {
            string resultPrice;

            if (itemPrice >= 5 && itemPrice <= 5000)
            {
                resultPrice = "The itemPrice is valid";
            }
            else
            {
                resultPrice = "The ItemPrice is not valid";
            }
            return resultPrice;
        }

        public static string ValidStockAmount(int stockAmount)
        {
            string resultAmount;            

            if (stockAmount >= 5 && stockAmount <= 500000)
            {
                resultAmount = "The StockAmount is valid";
            }
            else
            {
                resultAmount = "The StockAmount is not valid";
            }
            return resultAmount;
        }

        public string IncreaseStock(int increase)
        {
            if (increase < 0)
            {
                return "Increase amount cannot be negative";
            }
            else 
            {
                StockAmount += increase;
                return $"New stock: {StockAmount}";
            }
 
        }

        public string DecreaseStock(int decrease)
        {
            if (decrease < 0)
            {
                return "Decrease amount cannot be negative";
            }
            else if (decrease > StockAmount)
            {
                return "Decrease amount cannot be greater than Stock Amount";
            }
            else
            {
                StockAmount -= decrease;
                return $"New stock: {StockAmount}";
            }
        }

    }
}
