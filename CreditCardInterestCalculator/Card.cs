namespace CreditCardInterestCalculator
{
	public class Card : ICard
	{
		public Card(string cardType, decimal interestPercent)
		{
			CardType = cardType;
			InterestPercent = interestPercent;
		}

		public decimal Balance { get; set; }
		public decimal InterestPercent { get; }
		public string CardType { get; }

		public decimal CalculateInterest()
		{
			return Balance * (InterestPercent / 100M);
		}
	}
}
