namespace MonPendu.Core;

// Classe statique : on l'appelle directement avec MotMasque.Construire(...).
public static class MotMasque
{
    // Construit le texte à afficher pour le mot secret.
    // Exemple : motSecret = "maison", lettresTrouvees = "o"  ->  "_ _ _ o _ _"
    //
    // Les lettres trouvées sont reçues dans un simple string (ex. "eo") : c'est une suite
    // de caractères, et on peut demander si elle "contient" une lettre donnée.
    public static string Construire(string motSecret, string lettresTrouvees)
    {
        // Le texte qu'on va construire petit à petit. Il commence vide.
        string resultat = "";

        // foreach parcourt un à un les éléments d'une collection.
        // Un string est une suite de char (un char = un seul caractère, noté entre apostrophes : 'a').
        foreach (char lettre in motSecret)
        {
            // Contains renvoie true si lettresTrouvees contient cette lettre.
            if (lettresTrouvees.Contains(lettre))
            {
                resultat += lettre + " ";   // lettre trouvée : on l'affiche
            }
            else
            {
                resultat += "_ ";           // pas encore trouvée : on cache avec un tiret bas
            }
        }

        // Il reste un espace en trop à la fin ("m a i s o n "). TrimEnd() l'enlève.
        return resultat.TrimEnd();
    }
}
