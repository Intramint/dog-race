using System;
using System.Windows.Forms;

public class Guy
{
	public required string Name;
    public Bet? MyBet;
    public int Cash;

    public required RadioButton MyRadioButton;
    public required Label MyLabel;

    public void UpdateLabels(bool initialSetUp)
    {
        MyRadioButton.Text = Name + " ma " + Cash + " zł";
        if (MyBet != null)
        {
            MyLabel.Text = MyBet.GetDescription();
            return;
        }
        else if (!initialSetUp)
        {
            MyLabel.Text = Name + " nie zawarł zakładu";
        }
        else
        {
            MyLabel.Text = "";
        }
    }

    public void ClearBet()
    {
        MyBet = null;
    }

    public void PlaceBet(int Amount, int DogToWin)
    {
        MyBet = new Bet()
        {
            Amount = Amount,
            Dog = DogToWin,
            Bettor = this
        };
    }

    public void Collect(bool[] winners)
    {
        if (MyBet != null)
        {
            Cash += MyBet.PayOut(winners);
            ClearBet();
        }
        UpdateLabels(true);
    }
}
