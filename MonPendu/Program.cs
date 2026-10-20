// "using" permet d'utiliser les classes d'un autre espace de noms (ici : notre bibliothèque).
using MonPendu.Core;

// Point d'entrée du programme : C# exécute ce fichier de haut en bas.
Console.WriteLine("=== MonPendu ===");

// Random est un "générateur de nombres aléatoires". On en crée un avec new.
Random random = new Random();

// La logique du tirage vit maintenant dans la bibliothèque (MonPendu.Core),
// ce qui permet de la tester sans lancer le jeu.
string motSecret = Mots.TirerMot(random);

// TEMPORAIRE : affichage pour vérifier que ça marche. À supprimer plus tard,
// sinon le joueur verrait la réponse !
Console.WriteLine("(test) Mot secret : " + motSecret);
