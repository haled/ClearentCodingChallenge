using System.Collections.ObjectModel;
using System.Linq;

namespace CreditCardInterestCalculator
{
	public class Wallet : IInterestContainer
	{
		public Wallet()
		{
			Cards = new Collection<ICard>();
		}

		public Collection<ICard> Cards { get; }

		public decimal GetOwedInterest()
		{
			return Cards.Select(x => x.CalculateInterest()).Sum();
		}
	}
}
