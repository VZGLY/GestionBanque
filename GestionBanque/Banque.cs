namespace GestionBanque;

public class Banque
{
    #region Properties

    public string Nom { get; set; }
    public Dictionary<string, Courant> Comptes { get; set; } = new Dictionary<string, Courant>();


    #endregion

    #region Index

    public Courant this[string numero]
        {
            get
            {
                Courant c;
                Comptes.TryGetValue(numero, out c);
                return c;
            }
        }

    #endregion

    #region Methods

    public void AjouterCompte(Courant compte)
    {
        Comptes.Add(compte.Numero, compte);
    }

    public void SupprimerCompte(string numero)
    {
        Comptes.Remove(numero);
    }

    public double AvoirDesComptes(Personne personne)
    {
        double solde = 0;
        foreach (Courant compte in Comptes.Values)
        {
            if (compte.Titulaire == personne)
            {
                solde += compte;
            }
        }

        return solde;
    }

    #endregion
    
}