using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherLuck
{
	internal class Game
	{
		public Player first = new Player();
		public Player second = new Player();

		public int roundsLeft;
		public bool running;
		public bool firstTurn;
		public bool roundFinished;
		public int firstRoll;
		public int secondRoll;

		Random r = new Random();

		public void Start()
		{
			running = true;
			firstTurn = true;
			roundFinished = false;
			firstRoll = 0;
			secondRoll = 0;
		}

		public string TurnName()
		{
			if (firstTurn)
			{
				return first.name;
			}
			else
			{
				return second.name;
			}
		}

		public int Roll()
		{
			int value = r.Next(1, 7);
			roundFinished = false;

			if (firstTurn)
			{
				firstRoll = value;
				firstTurn = false;
			}
			else
			{
				secondRoll = value;
				GivePoints();
				roundsLeft = roundsLeft - 1;
				roundFinished = true;
				firstTurn = true;

				if (roundsLeft == 0)
				{
					running = false;
				}
			}

			return value;
		}

		private void GivePoints()
		{
			if (firstRoll > secondRoll)
			{
				first.points++;
			}
			else if (secondRoll > firstRoll)
			{
				second.points++;
			}
			else
			{
				first.points++;
				second.points++;
			}
		}

		public string GetResultText()
		{
			if (first.points > second.points)
			{
				return "The winner is " + first.NameUpper();
			}
			else if (second.points > first.points)
			{
				return "The winner is " + second.NameUpper();
			}
			else
			{
				return "No winner";
			}
		}

		public void Reset()
		{
			first.Reset();
			second.Reset();
			roundsLeft = 0;
			running = false;
			firstTurn = true;
			roundFinished = false;
			firstRoll = 0;
			secondRoll = 0;
		}
	}
}
