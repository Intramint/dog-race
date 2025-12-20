using dog_race.Properties;
using System;
using System.Data.SqlTypes;
using System.Net.Http.Headers;
using System.Windows.Forms.VisualStyles;

namespace dog_race
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            betLabels = new Label[] { janekBetLabel, bartekBetLabel, arekBetLabel };
            radioButtons = new RadioButton[] { radioButton1, radioButton2, radioButton3 };

            guys[0] = new Guy { Name = "Janek", Cash = 50, MyLabel = janekBetLabel, MyRadioButton = radioButton1 };
            guys[1] = new Guy { Name = "Bartek", Cash = 75, MyLabel = bartekBetLabel, MyRadioButton = radioButton2 };
            guys[2] = new Guy { Name = "Arek", Cash = 45, MyLabel = arekBetLabel, MyRadioButton = radioButton3 };
            for (int i = 0; i < 3; i++)
            {
                guys[i].UpdateLabels(true);
            }

            minimumBetValueLabel.Text = "Minimalny zak³ad to " + betCashUpDown.Minimum + " z³";
            updateMaxBetCashUpDown();

            double avgSpeed = (Greyhound.LowerSpeedBound + Greyhound.HigherSpeedBound) / 2;
            double avgAcceleration = (Greyhound.LowerAccelerationBound + Greyhound.HigherAccelerationBound) / 2;
            double avgStamina = (Greyhound.LowerStaminaBound + Greyhound.HigherStaminaBound) / 2;
            double weightedGreyhoundStatsAverage = (avgSpeed + avgAcceleration) / 6 + avgSpeed / 6 + (avgStamina + avgSpeed) / 4;

            Random random = new Random();
            greyhounds[0] = new Greyhound(random, dogPicture1, weightedGreyhoundStatsAverage);
            greyhounds[1] = new Greyhound(random, dogPicture2, weightedGreyhoundStatsAverage);
            greyhounds[2] = new Greyhound(random, dogPicture3, weightedGreyhoundStatsAverage);
            greyhounds[3] = new Greyhound(random, dogPicture4, weightedGreyhoundStatsAverage);
            for (int i = 0; i < 4; i++)
            {
                greyhounds[i].TakeStartingPosition();
            }


        }

        Label[] betLabels;
        RadioButton[] radioButtons;
        Guy[] guys = new Guy[3];
        Greyhound[] greyhounds = new Greyhound[4];
        int currentGuy = 0;
        bool[] winners = new bool[4] { false, false, false, false };
        bool finishJustCrossed = false;
        bool keepMovingAfterFinish = false;

        const int maxBetCap = 15;


        private void moveGreyhounds()
        {
            for (int i = 0; i < 4; i++)
            {
                if (greyhounds[i].Run() && !keepMovingAfterFinish)
                {
                    winners[i] = true;
                    finishJustCrossed = true;
                }
            }
        }

        private void updateBettorNameLabel()
        {
            bettorNameLabel.Text = guys[currentGuy].Name;
        }

        private void updateMaxBetCashUpDown()
        {
            int cash = guys[currentGuy].Cash;
            int cashCap;
            if (cash > maxBetCap)
            {
                cashCap = maxBetCap;
            }
            else if (cash <= betCashUpDown.Minimum)
            {
                cashCap = (int)betCashUpDown.Minimum;
            }
            else
            {
                cashCap = guys[currentGuy].Cash;
            }
            betCashUpDown.Maximum = cashCap;

        }

        public static double GetRandomDouble(double lowerBound, double higherBound, Random myRandom)
        {
            return myRandom.NextDouble() * (higherBound - lowerBound) + lowerBound;
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            foreach (var i in greyhounds)
            {
                i.total = 0;
                i.ticks = 0;
            }
            groupBox1.Enabled = false;
            for (int i = 0; i < 3; i++)
            {
                guys[i].UpdateLabels(false);
            }
            timer1.Start();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            currentGuy = 0;
            updateBettorNameLabel();
            updateMaxBetCashUpDown();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            currentGuy = 1;
            updateBettorNameLabel();
            updateMaxBetCashUpDown();
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            currentGuy = 2;
            updateBettorNameLabel();
            updateMaxBetCashUpDown();
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            guys[currentGuy].PlaceBet((int)betCashUpDown.Value, (int)betDogNumUpDown.Value);
            guys[currentGuy].UpdateLabels(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveGreyhounds();
            if (finishJustCrossed)
            {
                finishJustCrossed = false;
                keepMovingAfterFinish = true;
                int winnerCount = 0;
                int singleWinner = -1;
                for (int i = 0; i < 4; i++)
                {
                    if (winners[i])
                    {
                        greyhounds[i].Wins++;
                        winnerCount++;
                        singleWinner = i + 1;
                    }
                }
                if (winnerCount > 1)
                {
                    string[] winMessageParts = new string[4] { "", "", "", "" };
                    for (int i = 0; i < 4; i++)
                    {
                        if (winners[i])
                        {
                            winnerCount--;
                            if (winnerCount == 0)
                            {
                                winMessageParts[i] = i + 1 + "!";
                            }
                            else if (winnerCount == 1)
                            {
                                winMessageParts[i] = i + 1 + " i ";
                            }
                            else
                            {
                                winMessageParts[i] = i + 1 + ", ";
                            }
                        }
                    }

                   // MessageBox.Show("Wygra³y psy numer " + String.Join("", winMessageParts));
                }
                else
                {
                   // MessageBox.Show("Wygra³ pies numer " + singleWinner + "!");
                }
                string text = "";
                for(int i = 0; i < 4; i++) {
                    text += $"pies {i}, acc = {Math.Round(greyhounds[i].inherentAccelerationStat, 4)}, stam = {Math.Round(greyhounds[i].inherentStaminaStat, 4)}, speed = {Math.Round(greyhounds[i].inherentSpeedStat, 4)}, modifier = {Math.Round((double)greyhounds[i].total / (double)greyhounds[i].ticks ,4)} wins = {greyhounds[i].Wins}\r\n";
                }
                MessageBox.Show(text);

                timer1.Stop();
                keepMovingAfterFinish = false;
                for (int i = 0; i < 4; i++)
                {
                    greyhounds[i].TakeStartingPosition();
                }


                for (int i = 0; i < 3; i++)
                {
                    guys[i].Collect(winners);
                }

                for (int i = 0; i < 4; i++)
                {
                    winners[i] = false;
                }
                updateMaxBetCashUpDown();
                groupBox1.Enabled = true;
            }
        }
    }    
}
