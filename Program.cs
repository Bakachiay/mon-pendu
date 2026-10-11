// Point d'entrée du programme : C# exécute ce fichier de haut en bas.
Console.WriteLine("=== MonPendu ===");

// Un tableau (array) range plusieurs valeurs du même type dans une seule variable.
// Ici : une liste de mots (string = texte). Pas d'accents, pour simplifier la saisie.
string[] mots = { "ordinateur", "clavier", "maison", "fenetre", "voiture",
                  "bouteille", "chocolat", "montagne", "soleil", "parapluie" };

// Random est un "générateur de nombres aléatoires". On en crée un avec new.
Random random = new Random();

// Next(n) renvoie un entier au hasard de 0 à n-1 (n exclu).
// Les cases d'un tableau sont numérotées à partir de 0 : avec 10 mots, les indices vont de 0 à 9.
// mots.Length = nombre de cases du tableau, donc l'indice tiré est toujours valide.
int indice = random.Next(mots.Length);

// On récupère le mot à la case tirée : c'est le mot à deviner.
string motSecret = mots[indice];

// TEMPORAIRE : affichage pour vérifier que ça marche. À supprimer plus tard,
// sinon le joueur verrait la réponse !
Console.WriteLine("(test) Mot secret : " + motSecret);
