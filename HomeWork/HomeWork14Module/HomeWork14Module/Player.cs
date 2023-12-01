using System;
namespace HomeWork14Module
{
	public class Player
	{
		protected string Name { get; set; }
		List<Karta> cards = new List<Karta>();
		List<>

		public Player(string name)
		{
			this.Name = name;
		}

		public void PlayerCards(Karta card)
		{
			//cards.Add(card.);
		}

		public int TotalCards()
		{
			int sum = 0;

			for(int i = 0; i < cards.Capacity; i++)
			{
				sum += cards[i];
			}

			return sum;
		}
	}
}

