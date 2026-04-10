using CompositeExemple.Composite;

namespace TestProduit
{
    [TestClass]
    public sealed class TestProduits
    {
        [TestMethod]
        public void GivenANewProduct_When_AddingAProductToACompound_Then_TheProductIsAddedToTheCompound()
        {
            // Arrange
            Produit produit = new(1, "Produit 1", 10);
            ProduitCompound compound = new();

            //Act
            compound.AddProduit(produit);

            // Assert
            Assert.Contains(produit.ToString(), compound.ToString());
        }

        [TestMethod]
        public void GivenACompoundWithProducts_When_AddingOneQuantityToTheCompound_Then_TheQuantityOfAllProductsInTheCompoundIsIncreasedByOne()
        {
            // Arrange
            Produit produit1 = new(1, "Produit 1", 10);
            Produit produit2 = new(2, "Produit 2", 20);
            ProduitCompound compound = new();
            compound.AddProduit(produit1);
            compound.AddProduit(produit2);

            //Act
            compound.AjouterQuantite(1);

            // Assert
            Assert.AreEqual(11, produit1.Quantite);
            Assert.AreEqual(21, produit2.Quantite);
        }
    }
}
