namespace CompositeExemple.Composite
{
    public class Produit(int id, string nom, decimal prix, int quantite) : IProduit
    {
        public int Id { get; set; } = id;
        public string Nom { get; set; } = nom;
        public decimal Prix { get; set; } = prix;
        public int Quantite { get; set; } = quantite;

        public decimal CalculerPrix()
        {
            return Quantite * Prix;
        }

        public override string ToString()
        {
            return "Id: " + Id + " Nom: " + Nom + " Quantite: " + Quantite + " Prix: " + Prix;
        }
    }
}
