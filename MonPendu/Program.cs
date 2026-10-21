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

// TEMPORAIRE : lettres "trouvées" écrites en dur pour voir le masque en action.
// À l'étape suivante, elles viendront des saisies du joueur.
string lettresTrouvees = "eo";

// Affiche par exemple : _ _ _ _ _ e _ _ o
Console.WriteLine("Mot à deviner : " + MotMasque.Construire(motSecret, lettresTrouvees));
