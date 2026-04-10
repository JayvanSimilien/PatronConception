namespace CompositeExemple.Composite;

public class ProduitCompound
{
    private readonly List<IProduit> _produits = [];

    public void AddProduit(IProduit produit)
    {
        _produits.Add(produit);
    }

    public void RemoveProduit(int produit)
    {
        IProduit? produitTrouve = _produits.FirstOrDefault(p => p is Produit p1 && p1.Id == produit);
        if (produitTrouve == null) { return;}
        _produits.Remove(produitTrouve);
    }

    public void AjouterQuantite(int quantite)
    {
        foreach (var produit in _produits)
        {
            produit.AjouterQuantite(quantite);
        }
    }

    public override string ToString()
    {
        string result = "";
        foreach (var produit in _produits)
        {
            result += produit.ToString() + "\n";
        }
        return result;
    }
}