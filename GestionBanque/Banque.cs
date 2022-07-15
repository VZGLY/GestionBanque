namespace GestionBanque;

public class Banque 
{
    #region Properties

    public string Nom { get; set; }
    public Dictionary<string, Compte> Comptes { get; set; } = new Dictionary<string, Compte>();


    #endregion

    #region Index

    public Compte this[string numero]
        {
            get
            {
                Compte c;
                Comptes.TryGetValue(numero, out c);
                return c;
            }
        }

    #endregion

    #region Methods

    public void AjouterCompte(Compte compte)
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
        foreach (Compte compte in Comptes.Values)
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

