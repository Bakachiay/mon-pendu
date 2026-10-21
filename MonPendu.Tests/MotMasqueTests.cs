using MonPendu.Core;

namespace MonPendu.Tests;

public class MotMasqueTests
{
    [Fact]
    public void Construire_AucuneLettreTrouvee_AfficheQueDesTiretsBas()
    {
        string resultat = MotMasque.Construire("maison", "");

        Assert.Equal("_ _ _ _ _ _", resultat);
    }

    [Fact]
    public void Construire_ToutesLesLettresTrouvees_AfficheLeMotComplet()
    {
        string resultat = MotMasque.Construire("maison", "maison");

        Assert.Equal("m a i s o n", resultat);
    }

    [Fact]
    public void Construire_LettreEnPlusieursExemplaires_RevelleToutesLesOccurrences()
    {
        // "soleil" contient un seul 'l' ; on prend "bouteille" qui en a deux.
        string resultat = MotMasque.Construire("bouteille", "l");

        Assert.Equal("_ _ _ _ _ _ l l _", resultat);
    }

    [Fact]
    public void Construire_LettreAbsenteDuMot_NeChangeRien()
    {
        string resultat = MotMasque.Construire("maison", "z");

        Assert.Equal("_ _ _ _ _ _", resultat);
    }
}
