namespace GestionBanque.Interfaces;

internal interface ICustomer
{

    #region Properties

    double Solde { get; }

    #endregion

    #region Methods

    void Depot(double montant);
    
    void Retrait(double montant);

    #endregion
    

    
}