namespace MonPendu.Core;

// "static" : on n'a pas besoin de créer d'objet (pas de "new Mots()").
// On appelle directement Mots.TirerMot(...) et Mots.Liste.
public static class Mots
{
    // Un tableau (array) range plusieurs valeurs du même type dans une seule variable.
    // Ici : une liste de mots (string = texte). Pas d'accents, pour simplifier la saisie.
    public static readonly string[] Liste =
    {
        "ordinateur", "clavier", "maison", "fenetre", "voiture",
        "bouteille", "chocolat", "montagne", "soleil", "parapluie"
    };

    // Renvoie un mot de la liste choisi au hasard.
    // Le Random est reçu en paramètre (au lieu d'être créé ici) : ainsi, un test
    // peut fournir son propre Random et contrôler le résultat.
    public static string TirerMot(Random random)
    {
        // Next(n) renvoie un entier de 0 à n-1 (n exclu).
        // Les cases d'un tableau sont numérotées à partir de 0 : l'indice tiré est toujours valide.
        int indice = random.Next(Liste.Length);
        return Liste[indice];
    }

    // Indique si un mot est utilisable dans le jeu : non vide et uniquement des lettres a-z
    // (minuscules, sans accent). Renvoie true (vrai) ou false (faux).
    // Sert à vérifier un mot imposé par le développeur pour les tests.
    public static bool EstValide(string mot)
    {
        // Un mot vide ne peut pas être deviné.
        if (string.IsNullOrEmpty(mot))
        {
            return false;
        }

        foreach (char lettre in mot)
        {
            // Un seul caractère interdit suffit pour refuser tout le mot.
            if (lettre < 'a' || lettre > 'z')
            {
                return false;
            }
        }

        // Aucun caractère interdit trouvé : le mot est valide.
        return true;
    }
}
