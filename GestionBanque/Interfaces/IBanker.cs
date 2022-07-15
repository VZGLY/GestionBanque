using GestionBanque;

namespace GestionBanque.Interfaces;

internal interface IBanker
{
    #region Properties

    double Solde { get; }
    Personne Titulaire { get; set; }


    #endregion


    #region Methods

    void Depot(double montant);
    
    void Retrait(double montant);

    void AppliquerInteret();

    #endregion
    


}