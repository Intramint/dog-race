using dog_race;
using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Windows.Forms;

public class Greyhound
{
	private const int startingPosition = 25;
	private const int finishline = 652;
	private const int racetrackLength = finishline - startingPosition;
	private PictureBox MyPictureBox;
	private Random myRandom;
	private double location = startingPosition;

	private double inherentSpeedStat;
	public const double LowerSpeedBound = 1.5;
	public const double HigherSpeedBound = 2.5;

	private double inherentAccelerationStat; // affects negative or positive speed change in roughly the 1st 1/3 of the race
	public const double LowerAccelerationBound = 0.5;
	public const double HigherAccelerationBound = 1.5;

	private double inherentStaminaStat; //same but the last 40% instead
	public const double LowerStaminaBound = 0.5;
	public const double HigherStaminaBound = 1.3;

    private double randomSpeedModifier = 1;
	private const double lowerModifierBound = 0.8;
	private const double higherModifierBound = 1.2;
	private const double lowerModifierChangeBound = -0.1;
	private const double higherModifierChangeBound = 0.1;

    private double currentAccelerationModifier;
    private double currentStaminaModifier;

	private const int distanceBetweenTicks = 6; //ticks tell when to modify speed due to stamina or acceleration
    private const int numberOfTrackTicks = racetrackLength / distanceBetweenTicks;
	private int nextTrackTick = startingPosition + distanceBetweenTicks;

    public Greyhound(Random MyRandom, PictureBox MyPictureBox, double weightedAverageStats)
	{
		this.myRandom = MyRandom;
		this.MyPictureBox = MyPictureBox;
		rollStats(weightedAverageStats);
    }


    public bool Run() //jest jakiś lepszy sposób na ułożenie wszystkich metod, żeby łatwiej je było znaleźć w kodzie? może najpierw public, a potem private oraz posegregowane po typie zwracanej zmiennej? Czy może jakoś rozbić na więcej plików i użyć partial class?
    {
		double move = calculateSpeed();
        location += move;

        MyPictureBox.Left = (int)location;
        if (MyPictureBox.Left >= finishline)
        {
            return true;
        }
        return false;
    }

	private double calculateSpeed()
	{
		if (passedTrackTick())
		{
			if (isSecondHalf())
			{
				currentStaminaModifier -= (1 - inherentStaminaStat) / (numberOfTrackTicks / 2);
			}

			if (isFirstThird())
			{
				currentAccelerationModifier += (1 - inherentAccelerationStat) / (numberOfTrackTicks / 3);
			}
			else if (currentAccelerationModifier != 1)
			{
				currentAccelerationModifier = 1;
			}
			
		}
        
		rollRandomSpeedModifier();

		return inherentSpeedStat * randomSpeedModifier * currentStaminaModifier * currentAccelerationModifier;
    }
    private bool isSecondHalf()
	{
		if (location - startingPosition > racetrackLength * 0.6)
		{
			return true;
		}
		return false;
	}

	private bool isFirstThird()
	{
		if ((inherentAccelerationStat > 1 && currentAccelerationModifier > 1) || (inherentAccelerationStat < 1 && currentAccelerationModifier < 1))
		{
			return true;
		}
		return false;
	}

	private void rollStats(double weightedAverageStats)
	{
		inherentSpeedStat = rollInherentDogSpeed(weightedAverageStats);
		inherentAccelerationStat = rollInherentDogAccelerationStat(weightedAverageStats);
		inherentStaminaStat = rollInherentDogStaminaStat(weightedAverageStats);
	}


	private bool passedTrackTick() //tells when to modify speed due to stamina or acceleration
    {
		if (location + startingPosition > nextTrackTick)
		{
			nextTrackTick += distanceBetweenTicks;
            return true;
		}
		return false;
	}


    public void TakeStartingPosition()
	{
		MyPictureBox.Left = startingPosition;
		location = startingPosition;
		currentAccelerationModifier = inherentAccelerationStat;
		currentStaminaModifier = 1;
		nextTrackTick = startingPosition;
    }


    private double rollInherentDogSpeed(double weightedAverageStats)  //weightedAverageStats = (inherentSpeedStat + inherentAccelerationStat) / 6 + inherentSpeedStat / 6 + (inherentStaminaStat + inherentSpeedStat) / 4;
    {
		double maximumSpeed = Math.Min((-2 * LowerAccelerationBound + 12 * weightedAverageStats - 3 * LowerStaminaBound) / 7, HigherSpeedBound);
        double minimumSpeed = Math.Max((-2 * HigherAccelerationBound + 12 * weightedAverageStats - 3 * HigherStaminaBound) / 7, LowerSpeedBound);

        //v = (-2a + 12w - 3s)/7        //a, acceleration st = stamina, v = speed, w = weighted average
        return Form1.GetRandomDouble(minimumSpeed, maximumSpeed, myRandom);
	}

    private double rollInherentDogAccelerationStat(double weightedAverageStats)  //weightedAverageStats = (inherentSpeedStat + inherentAccelerationStat) / 6 + inherentSpeedStat / 6 + (inherentStaminaStat + inherentSpeedStat) / 4;
    {
		double maximumAcceleration = Math.Min((-3 * LowerStaminaBound - 7 * inherentSpeedStat + 12 * weightedAverageStats) / 2, HigherAccelerationBound);
		double minimumAcceleration = Math.Max((-3 * HigherStaminaBound - 7 * inherentSpeedStat + 12 * weightedAverageStats) / 2, LowerAccelerationBound);

        return Form1.GetRandomDouble(minimumAcceleration, maximumAcceleration, myRandom);
        //a = (-3st - 7v + 12w)/2      //a, acceleration st = stamina, v = speed, w = weighted average

    }

    private double rollInherentDogStaminaStat(double weightedAverageStats) //weightedAverageStats = (inherentSpeedStat + inherentAccelerationStat) / 6 + inherentSpeedStat / 6 + (inherentStaminaStat + inherentSpeedStat) / 4;
    {
        return 4 * (weightedAverageStats - (inherentSpeedStat + inherentAccelerationStat) / 6 - inherentSpeedStat / 6) - inherentSpeedStat;
        //st = 4 * (w - (v + a)/6 - v/6) - v        //a, acceleration st = stamina, v = speed, w = weighted average

    }
    private void rollRandomSpeedModifier()
	{
		double roll = myRandom.NextDouble(); //czy tutaj lepiej by bylo użyc floata?

		if (roll <= (double) 1 / 80) //happens around 4 times per race per dog
		{
			double minimumSpeedChange = (higherModifierChangeBound - lowerModifierChangeBound) / 8; //prevents insignificant speed changes
			double speedChange = Form1.GetRandomDouble(lowerModifierChangeBound, higherModifierChangeBound, myRandom);
			if (Math.Abs(speedChange) < minimumSpeedChange)
			{
				if (speedChange < 0)
				{
					speedChange -= minimumSpeedChange;
				}
				else
				{
					speedChange += minimumSpeedChange;
				}
			}
			double newSpeed = randomSpeedModifier + speedChange;
			if (roll > (double) 1 / 320)
			{

				if (newSpeed > higherModifierBound)
				{
					newSpeed = 2 * higherModifierBound - newSpeed; //"bounces" back when hitting the higher bound, which means it could end up with lower speed, even with positive speedChange
				}
				else if (newSpeed < lowerModifierBound)
				{
					newSpeed = 2 * lowerModifierBound - newSpeed;
				}

			}
			else
			{ //small chance to triple the speed change
				newSpeed += speedChange * 2;
				newSpeed = double.Min(newSpeed, higherModifierBound);
				newSpeed = double.Max(newSpeed, lowerModifierBound);
			}
			randomSpeedModifier = newSpeed;
		}
	}
}
