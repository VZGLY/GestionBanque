﻿namespace GestionBanque;

public class Epargne : Compte
{
    #region Private fields

    private DateTime _dateDernierRetrait;

    #endregion

    #region Properties

    public DateTime DateDernierRetrait
    {
        get
        {
            return _dateDernierRetrait;
        }
        set
        {
            _dateDernierRetrait = value;
        }
    }

    #endregion
}