using System;
using System.Windows.Forms;

public class Guy
{
	public string Name;
    public Bet MyBet;
    public int Cash;

    public RadioButton MyRadioButton;
    public Label MyLabel;

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

    public bool PlaceBet(int Amount, int DogToWin)
    {
        if (Amount <= Cash)
        {
            MyBet = new Bet()
            {
                Amount = Amount,
                Dog = DogToWin,
                Bettor = this
            };
            return true;
        }
        else
        {
            return false;
        }
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
