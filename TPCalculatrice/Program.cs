using TPCalculatrice;

Console.WriteLine("Bienvenu sur ma calculatrice !");

Console.WriteLine("Entre le premier nombre :");
int nb1 = int.Parse(Console.ReadLine());

Console.WriteLine("Entre le deuxième nombre :");
int nb2 = int.Parse(Console.ReadLine());

Console.WriteLine("Quelle opération souhaite tu faire ? (Entre le symbole)");
string operateur = Console.ReadLine();

var Calc = new Calculatrice();
int resultat = 0;

if(operateur == "+")
{
	resultat = Calc.Addition(nb1, nb2);
}
else if(operateur == "-")
{
	resultat = Calc.Soustraction(nb1, nb2);
}
else if(operateur == "*")
{
	resultat = Calc.Multiplication(nb1, nb2);
}
else if(operateur == "/")
{
	resultat = Calc.Division(nb1, nb2);
}
else if(operateur == "%")
{
	resultat = Calc.Modulo(nb1, nb2);
}
else
{
	Console.WriteLine("ERREUR : Opérateur non reconnu");
	return;
}

Console.WriteLine($"Le résultat de votre opération est {resultat} !");