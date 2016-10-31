namespace CreditCardInterestCalculator
{
	public interface ICard
	{
		decimal Balance { get; set; }
		decimal InterestPercent { get; }
		string CardType { get; }
		decimal CalculateInterest();
	}
}
