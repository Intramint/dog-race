using System;
using System.Windows.Forms;

public class Bet
{
	public int Amount;
	public int Dog;
	public Guy Bettor;

	public string GetDescription() {
		return Bettor.Name + " postawił " + Amount + " zł na psa numer " + Dog;
	}
	public int PayOut(bool[] winners)
	{
		if (winners[Dog - 1] == true)
		{
			return Amount;
		}
		else
		{
			return -Amount;
		}
	}

	}
