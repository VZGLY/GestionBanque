namespace GestionBanque;

public abstract class Compte
{
    #region Private Fields

    private string _numero;
    private double _solde;
    private Personne _titulaire;

    #endregion
    
    #region Properties

    public double Solde
    {
        get { return _solde; }
        protected set { _solde = value; }
    }
    
    public string Numero
    {
        get { return _numero; }
        set { _numero = value; }
    }
    
    public Personne Titulaire
    {
        get { return _titulaire; }
        set { _titulaire = value; }
    }

    #endregion

    #region Methods

    public virtual void Retrait(double montant)
    {
        if (montant <= 0)
            return;
        if (Solde - montant > 0)
            return;
        
        
        Solde -= montant;
    }
    
    public void Depot(double montant)
    {
        if (montant <= 0)
            return;
        
        Solde += montant;
        
    }

    public double AppliquerInteret()
    {
        return Solde + CalculeInteret();
    }

    protected abstract double CalculeInteret();
    
    
    #endregion

    #region Operators

    public static double operator +(double valeur, Compte compte)
    {
        
        if (compte.Solde > 0)
            valeur += compte.Solde;
        return valeur;

    }

    #endregion
    
}