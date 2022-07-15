namespace GestionBanque;

public class Courant : Compte
{
    #region Private Fields
    
    private double _ligneDeCredit;

    #endregion

    #region Properties
    
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
   
    

    #endregion

    #region Methods

    public override void Retrait(double montant)
    {
        if (montant <= 0)
            return;

        if (montant > Solde + LigneDeCredit)
            return;
        
        Solde -= montant;
    }

    protected override double CalculeInteret()
    {
        return Solde * 0.03;
    }

    #endregion

}