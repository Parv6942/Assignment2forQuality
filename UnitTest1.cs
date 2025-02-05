using NUnit.Framework.Legacy;
using ProductConstructor;
using System;

namespace ProductTest
{
    public class Tests
    {
        private ProductConstruct product;
        [SetUp]
        public void Setup()
        {
        }

        // Test case 1 for Product ID
        [Test]
        public void ValidID_Minimum_OutputPass()
        {
            //Arrange
            product = new ProductConstruct(5, "Test Product1", 10000, 1000);

            string expected = "The ProdID is valid";

            //Act
            string actual = ProductConstruct.ValidProductId(product.ProdID);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test case 2 for Product ID
        [Test]
        public void ValidID_Maximum_OutputPass()
        {
            //Arrange
            product = new ProductConstruct(50000, "Test Product2", 10000, 1000);

            string expected = "The ProdID is valid";

            //Act
            string actual = ProductConstruct.ValidProductId(product.ProdID);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test case 3 for Product ID
        [Test]
        public void ValidID_Average_OutputPass()
        {
            //Arrange
            product = new ProductConstruct(25000, "Test Product3", 10000, 1000);

            string expected = "The ProdID is valid";

            //Act
            string actual = ProductConstruct.ValidProductId(product.ProdID);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test case 4 for Product Name
        [Test]
        public void ValidName_CorrectName_OutputPass()
        {
            //Arrange
            product = new ProductConstruct(25000, "Test Product", 10000, 1000);

            string expected = "The ProdName is valid";

            //Act
            string actual = ProductConstruct.ValidProductName(product.ProdName);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test case 5 for Product Name
        [Test]
        public void ValidName_InCorrectName_OutputPass()
        {
            //Arrange
            product = new ProductConstruct(25000, "Test Products", 10000, 1000);

            string expected = "The ProdName is not valid";

            //Act
            string actual = ProductConstruct.ValidProductName(product.ProdName);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test case 6 for Product Name
        [Test]
        public void ValidName_NullName_OutputPass()
        {
            //Arrange
            product = new ProductConstruct(25000, "", 10000, 1000);

            string expected = "The ProdName is not valid";

            //Act
            string actual = ProductConstruct.ValidProductName(product.ProdName);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test case 7 for Item Price
        [Test]
        public void ValidPrice_Minimum_OutputPass()
        {
            //Arrange
            product = new ProductConstruct(25000, "Test Product7", 5, 1000);

            string expected = "The itemPrice is valid";

            //Act
            string actual = ProductConstruct.ValidProductPrice(product.ItemPrice);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        // Test case 8 for Item Price
        [Test]
        public void ValidPrice_Maximum_OutputPass()
        {
            //Arrange
            product = new ProductConstruct(25000, "Test Product8", 5000, 1000);

            string expected = "The itemPrice is valid";

            //Act
            string actual = ProductConstruct.ValidProductPrice(product.ItemPrice);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        // Test case 9 for Item Price
        [Test]
        public void ValidPrice_Average_OutputPass()
        {
            //Arrange
            product = new ProductConstruct(25000, "Test Product9", 2500, 1000);

            string expected = "The itemPrice is valid";

            //Act
            string actual = ProductConstruct.ValidProductPrice(product.ItemPrice);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test case 10 for StockAmount
        [Test]
        public void ValidStock_Minimum_OutputPass()
        {
            //Arrange
            product = new ProductConstruct(25000, "Test Product10", 2500, 5);

            string expected = "The StockAmount is valid";

            //Act
            string actual = ProductConstruct.ValidStockAmount(product.StockAmount);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        // Test case 11 for StockAmount
        [Test]
        public void ValidStock_Average_OutputPass()
        {
            //Arrange
            product = new ProductConstruct(25000, "Test Product11", 2500, 250000);

            string expected = "The StockAmount is valid";

            //Act
            string actual = ProductConstruct.ValidStockAmount(product.StockAmount);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test case 12 for StockAmount
        [Test]
        public void ValidStock_Maximum_OutputPass()
        {
            //Arrange
            product = new ProductConstruct(25000, "Test Product12", 2500, 500000);

            string expected = "The StockAmount is valid";

            //Act
            string actual = ProductConstruct.ValidStockAmount(product.StockAmount);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test case 13 for Stock Increase
        [Test]
        public void ValidAmount_IncreaseStock_OutputPass()
        {
            //Arrange
            product = new ProductConstruct(25000, "Test Product13", 2500, 1000);

            string expected = $"New stock: {1500}";

            //Act
            string actual = product.IncreaseStock(500);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test case 14 for Stock Increase
        [Test]
        public void InValidAmount_IncreaseStock_OutputPass()
        {
            //Arrange
            product = new ProductConstruct(25000, "Test Product14", 2500, 1000);
            

            string expected = "Increase amount cannot be negative";

            //Act
            string actual = product.IncreaseStock(-500);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test case 15 for Stock Increase
        [Test]
        public void ZeroAmount_IncreaseStock_OutputPass()
        {
            //Arrange
            product = new ProductConstruct(25000, "Test Product15", 2500, 1000);


            string expected = $"New stock: {1000}";

            //Act
            string actual = product.IncreaseStock(0);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test case 16 for Stock Decrease
        [Test]
        public void ValidAmount_DecreaseStock_OutputPass()
        {
            //Arrange
            product = new ProductConstruct(25000, "Test Product16", 2500, 1000);

            string expected = $"New stock: {500}";

            //Act
            string actual = product.DecreaseStock(500);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test case 17 for Stock DEcrease
        [Test]
        public void InValidAmount_DecreaseStock_OutputPass()
        {
            //Arrange
            product = new ProductConstruct(25000, "Test Product17", 2500, 1000);


            string expected = "Decrease amount cannot be negative";

            //Act
            string actual = product.DecreaseStock(-500);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test case 18 for Stock Decrease
        [Test]
        public void OverStock_DecreaseStock_OutputPass()
        {
            //Arrange
            product = new ProductConstruct(25000, "Test Product18", 2500, 1000);


            string expected = $"Decrease amount cannot be greater than Stock Amount";

            //Act
            string actual = product.DecreaseStock(1200);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}