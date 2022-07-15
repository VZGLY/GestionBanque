namespace GestionBanque;

public class Personne
{

    #region PrivateFields

    private string _nom;
    private string _prenom;
    private DateTime _dateNaiss;

    #endregion

    #region Properties

    public string Nom
    {
        get { return _nom;}
        set { _nom = value; }
    }
    public string Prenom
    {
        get { return _prenom;}
        set { _prenom = value; }
    }
    public DateTime DateNaiss
    {
        get { return _dateNaiss;}
        set { _dateNaiss = value; }
    }

    #endregion
    
}