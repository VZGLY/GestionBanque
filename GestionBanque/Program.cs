using System.Security.Cryptography;
using GestionBanque;

Courant C1 = new Courant();
C1.Numero = "1234567890";
Personne P1 = new Personne();
P1.Prenom = "Merlin";
P1.Nom = "Leroy";
P1.DateNaiss = DateTime.Now.AddYears(-25).AddDays(-124);
Courant C2 = new Courant();
C2.Numero = "1234567892";
C2.Depot(250);

C1.Titulaire = P1;
C2.Titulaire = P1;

C1.LigneDeCredit = 2000;

C1.Depot(245.56);

C1.Retrait(132.45);



Banque b = new Banque();

b.AjouterCompte(C1);
b.AjouterCompte(C2);



Console.WriteLine(b.AvoirDesComptes(P1));




