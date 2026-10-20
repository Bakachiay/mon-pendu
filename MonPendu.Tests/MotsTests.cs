using MonPendu.Core;

namespace MonPendu.Tests;

public class MotsTests
{
    // [Fact] marque une méthode comme un test : xUnit la lance et la déclare
    // réussie si aucun Assert n'échoue.
    // Convention de nom : Quoi_Condition_Résultat attendu.

    [Fact]
    public void Liste_EstInitialisee_ContientDesMots()
    {
        Assert.NotNull(Mots.Liste);
        Assert.NotEmpty(Mots.Liste);
    }

    [Fact]
    public void Liste_ChaqueMot_EstEnMinusculesSansAccent()
    {
        foreach (string mot in Mots.Liste)
        {
            Assert.False(string.IsNullOrWhiteSpace(mot), "Un mot de la liste est vide.");

            // Chaque lettre doit être entre 'a' et 'z' (donc ni accent, ni majuscule, ni espace).
            foreach (char lettre in mot)
            {
                Assert.True(lettre >= 'a' && lettre <= 'z',
                    "Le mot \"" + mot + "\" contient un caractère interdit : " + lettre);
            }
        }
    }

    [Fact]
    public void Liste_NeContientPasDeDoublon()
    {
        // Distinct() retire les doublons : si la taille ne change pas, il n'y en avait pas.
        // (C'est du LINQ, on y reviendra plus tard.)
        Assert.Equal(Mots.Liste.Length, Mots.Liste.Distinct().Count());
    }

    [Fact]
    public void TirerMot_RenvoieToujoursUnMotDeLaListe()
    {
        Random random = new Random();

        for (int i = 0; i < 100; i++)
        {
            string mot = Mots.TirerMot(random);
            Assert.Contains(mot, Mots.Liste);
        }
    }

    [Fact]
    public void TirerMot_SurPlusieursTirages_RenvoieDesMotsDifferents()
    {
        Random random = new Random();
        // Un HashSet est une collection qui ignore les doublons : parfait pour compter
        // combien de mots différents ont été tirés.
        HashSet<string> motsTires = new HashSet<string>();

        for (int i = 0; i < 100; i++)
        {
            motsTires.Add(Mots.TirerMot(random));
        }

        // Ne voir qu'un seul mot sur 100 tirages est quasiment impossible (1 chance sur 10^99).
        Assert.True(motsTires.Count > 1, "Le tirage renvoie toujours le même mot.");
    }
}
