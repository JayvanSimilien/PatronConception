namespace CompositeExemple.Composite;

public class ProduitCompound : IProduit
{
    private readonly List<IProduit> _produits = [];

    public void AddProduit(IProduit produit)
    {
        _produits.Add(produit);
    }

    public void RemoveProduit(IProduit produit)
    {
        _produits.Remove(produit);
    }

    public decimal CalculerPrix()
    {
        decimal prixTotal = 0;
        foreach (var produit in _produits)
        {
            prixTotal += produit.CalculerPrix();
        }
        return prixTotal;
    }

    public override string ToString()
    {
        string result = "";
        foreach (var produit in _produits)
        {
            result += produit + "\n";
        }
        return result;
    }
}