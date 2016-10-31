using System.Collections.ObjectModel;
using System.Linq;

namespace CreditCardInterestCalculator
{
    public class Person : IInterestContainer
	{
	    public Person()
	    {
		    Wallets = new Collection<Wallet>();
	    }

		public Collection<Wallet> Wallets { get; }

	    public decimal GetOwedInterest()
	    {
		    return Wallets.SelectMany(x => x.Cards).Select(x => x.CalculateInterest()).Sum();
	    }
    }
}
