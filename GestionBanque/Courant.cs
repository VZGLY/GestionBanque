namespace GestionBanque;

public class Courant
{
    #region Private Fields

    private string _numero;
    private double _solde;
    private double _ligneDeCredit;
    private Personne _titulaire;

    #endregion

    #region Properties

    public string Numero
    {
        get { return _numero; }
        set { _numero = value; }
    }
    public double Solde
    {
        get { return _solde; }
        private set { _solde = value; }
    }
    
    public double LigneDeCredit
    {
        get { return _ligneDeCredit; }
        set
        {
            if (value < 0)
            {
                return;
            }
            else
            {
                _ligneDeCredit = value;
            }
        }
    }

    public Personne Titulaire
    {
        get { return _titulaire; }
        set { _titulaire = value; }
    }

    #endregion

    #region Methods

    public void Retrait(double montant)
    {
        if (montant <= 0)
            return;

        if (montant > Solde + LigneDeCredit)
            return;
        
        Solde -= montant;
            
        
    }
    
    public void Depot(double montant)
    {
        if (montant <= 0)
            return;
        
        Solde += montant;
        
    }

    #endregion

    #region Operators

    public static double operator +(double valeur, Courant compte)
    {
        
        if (compte.Solde > 0)
            valeur += compte.Solde;
        return valeur;

    }

    #endregion
}