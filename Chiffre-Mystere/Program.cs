// Variables
int nbreVie = 15;
int nbreMin = 1;
int nbreMax = 100_000;
bool search = true;
bool enVie = true;

// Nombre entre 1 et 100.000 généré aléatoirement
Random random = new Random();
int nbreMystere = random.Next(1, 100001);

// Collections
List<int> listEssais = new List<int>();

// Introduction
Console.Clear();
Console.WriteLine("Bonjour et bienvenue dans le jeu de Leweaz !");
Console.WriteLine("Pour commencer, comment t'appelles-tu ?");
string prenom = Console.ReadLine();

Console.Clear();
Console.WriteLine($"Bonjour {prenom} ! Nous allons pouvoir commencer. Il faut trouver le nombre caché. Il se trouve entre 1 et 100 000 !");
Console.WriteLine("Saisie le mot \"go\" quand tu es prêt !");
string start = Console.ReadLine();
Console.Clear();

while (start != "go")
{
    Console.WriteLine($"Attention {prenom} ! Saisie le mot \"go\" quand tu es prêt et pas autre chose !");
    start = Console.ReadLine();
    Console.Clear();
}


// ---------- Début du jeu ----------
while (enVie && search)
{
    // Vies
    Console.WriteLine($"Nombre de vies restantes : {nbreVie}. Tic tac, tic tac...");
    Console.WriteLine();

    // Liste des nombres saisis
    if (listEssais is not [])
    {
        Console.Write("Tu as testé les nombres suivants :");
        foreach (int nbreList in listEssais)
        {
            Console.Write($" {nbreList} - ");
        }
        Console.WriteLine();
    }

    // Saisie du nombre mystère
    Console.WriteLine($"Quel est le nombre mystère {prenom} ?");
    int nbreSaisi = 0;

    while (nbreSaisi < nbreMin || nbreSaisi > nbreMax)
    {
        try
        {
            nbreSaisi = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Fais attention à saisir une valeur correcte, c'est à dire un nombre entre 1 et 100 000 !");
            nbreSaisi = 0;
        }
    }

    // Vérifie si le nombre saisi est déjà présent dans la liste
    while (listEssais.Contains(nbreSaisi))
    {
        Console.WriteLine("Attention, tu as déjà saisi cette valeur !");
        nbreSaisi = 0;
        while (nbreSaisi < nbreMin || nbreSaisi > nbreMax)
        {
            try
            {
                nbreSaisi = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Fais attention à saisir une valeur correcte, c'est à dire un nombre entre 1 et 100 000 !");
                nbreSaisi = 0;
            }
        }
    }
    Console.Clear();
    listEssais.Add(nbreSaisi);

    // Réponse (Correct, + ou -)
    if (nbreSaisi == nbreMystere)
    {
        search = false;
        Console.WriteLine($"Bravo {prenom}, tu as trouvé le nombre mystère ! C'était {nbreMystere} !");
    }
    else if (nbreSaisi < nbreMystere)
    {
        Console.WriteLine("Mauvaise réponse, c'est plus !");
        nbreVie--;
    }
    else if (nbreSaisi > nbreMystere)
    {
        Console.WriteLine("Mauvaise réponse, c'est moins !");
        nbreVie--;
    }

    if (nbreVie == 0)
    {
        Console.Clear();
        enVie = false;
        Console.WriteLine($"Game over, tu as perdu toutes tes vies ! Le nombre mystère était {nbreMystere}... À très bientôt !");
    }
}