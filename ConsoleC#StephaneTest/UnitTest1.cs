using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleC_Stephane;


namespace ConsoleC_StephaneTest
{
    [TestClass]
    public class ConsoleC_Test
    {
        // marge d'erreur pour considerer resultat identique
        double delta = 0.00001;

        [TestMethod]
        public void DoOperation_adition()
        {
            // Preparation
            double num1 = 3;
            double num2 = 4;
            string op = "a";     // addition

            // Action
            double resultatCalcule = Calculator.DoOperation(num1, num2, op);
            double resultatTheorique = 7;

            // Comparaison
            Assert.AreEqual(resultatCalcule, resultatTheorique,delta);
        }

        [TestMethod]
        public void DoOperation_soustraction()
        {
            // Preparation
            double num1 =1.2;
            double num2 = 3.3;
            string op = "s";     // soustraction

            // Action
            double resultatCalcule = Calculator.DoOperation(num1, num2, op);
            double resultatTheorique = -2.1;

            // Comparaison
            Assert.AreEqual(resultatCalcule, resultatTheorique,delta);
        }
    }
}