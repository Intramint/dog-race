using System;
using System.Windows.Forms;

public class Bet
{
	public required int Amount;
	public required int Dog;
	public required Guy Bettor;

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
