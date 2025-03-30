using System;

namespace TPCalculatrice;

public class Calculatrice
{
	/// <summary>
	/// Ceci est un test
	/// </summary>
	/// <param name="nb1">blablabla</param>
	/// <param name="nb2">suuuui</param>
	/// <returns></returns>
	public int Addition(int nb1, int nb2)
	{
		return nb1 + nb2;
	}
	public int Soustraction(int nb1, int nb2)
	{
		return nb1 - nb2;
	}
	public int Multiplication(int nb1, int nb2)
	{
		return nb1 * nb2;
	}
	public int Division(int nb1, int nb2)
	{
		if(nb2 == 0)
		{
			return 0;
		}
		return nb1 / nb2;
	}
	public int Modulo(int nb1, int nb2)
	{
		return nb1 % nb2;
	}

	public int operandeDeGauche;
	
}
