using CompositeExemple.Composite;

namespace TestProduit
{
    [TestClass]
    public sealed class TestProduits
    {
        [TestMethod]
        public void GivenACompoundWithProducts_When_ConvertingACompoundToString_Then_TheCompoundReturnsTheStringOfAllOfItsProducts()
        {
            // Arrange
            Produit produit = new(1, "Cellulaire", 699m, 2);
            Produit produit2 = new(3, "Clavier", 199m, 5);

            ProduitCompound compound = new();

            compound.AddProduit(produit);
            compound.AddProduit(produit2);

            //Act
            string compoundString = compound.ToString();
            // Assert
            Assert.AreEqual(produit + "\n" + produit2 + "\n", compoundString);
        }

        [TestMethod]
        public void GivenACompoundWithProducts_When_CalculatingPriceOfTheCompound_Then_TheCalculatedPriceOfAllProductsInTheCompoundIsSummedUp()
        {
            // Arrange
            Produit produit1 = new(1, "Cellulaire", 699m, 2);
            Produit produit2 = new(2, "Écouteurs 2", 199m, 1);

            ProduitCompound compound = new();

            compound.AddProduit(produit1);
            compound.AddProduit(produit2);

            //Act
            decimal prixTotal = compound.CalculerPrix();

            // Assert
            Assert.AreEqual(1597m, prixTotal);
        }
    }
}
