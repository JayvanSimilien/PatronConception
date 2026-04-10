namespace CompositeExemple.Composite
{
    public class Produit(int id, string nom, int quantite) : IProduit
    {
        public int Id { get; set; } = id;
        public string Nom { get; set; } = nom;
        public int Quantite { get; set; } = quantite;

        public void AjouterQuantite(int quantite)
        {
            Quantite++;
        }

        public override string ToString()
        {
            return "Id: " + Id + " Nom: " + Nom + " Quantite: " + Quantite;
        }
    }
}
