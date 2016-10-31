using NUnit.Framework;

namespace CreditCardInterestCalculator.Tests
{
	[TestFixture]
	public class CreditCardInterestCalculatorTests
    {
		[Test]
		public void Test1()
		{
			Person person = new Person();
			Wallet wallet1 = new Wallet();
			person.Wallets.Add(wallet1);
			wallet1.Cards.Add(new Card("Visa", 10M) { Balance = 100M });
			wallet1.Cards.Add(new Card("MC", 5M) { Balance = 100M});
			wallet1.Cards.Add(new Card("Discover", 1M) { Balance = 100M });

			Assert.AreEqual(person.GetOwedInterest(), 16M);
			Assert.AreEqual(wallet1.Cards[0].CalculateInterest(), 10M);
			Assert.AreEqual(wallet1.Cards[1].CalculateInterest(), 5M);
			Assert.AreEqual(wallet1.Cards[2].CalculateInterest(), 1M);
		}

		[Test]
		public void Test2()
		{
			Person person = new Person();
			Wallet wallet1 = new Wallet();
			Wallet wallet2 = new Wallet();
			person.Wallets.Add(wallet1);
			person.Wallets.Add(wallet2);
			wallet1.Cards.Add(new Card("Visa", 10M) { Balance = 100M });
			wallet1.Cards.Add(new Card("Discover", 1M) { Balance = 100M });
			wallet2.Cards.Add(new Card("MC", 5M) { Balance = 100M });

			Assert.AreEqual(person.GetOwedInterest(), 16M);
			Assert.AreEqual(wallet1.GetOwedInterest(), 11M);
			Assert.AreEqual(wallet2.GetOwedInterest(), 5M);
		}

		[Test]
		public void Test3()
		{
			Person person1 = new Person();
			Wallet person1Wallet = new Wallet();
			person1.Wallets.Add(person1Wallet);
			person1Wallet.Cards.Add(new Card("MC", 5M) { Balance = 100M });
			person1Wallet.Cards.Add(new Card("Visa", 10M) { Balance = 100M });
			person1Wallet.Cards.Add(new Card("Discover", 1M) { Balance = 100M });

			Assert.AreEqual(person1.GetOwedInterest(), 16M);
			Assert.AreEqual(person1Wallet.GetOwedInterest(), 16M);

			Person person2 = new Person();
			Wallet person2Wallet = new Wallet();
			person2.Wallets.Add(person2Wallet);
			person2Wallet.Cards.Add(new Card("MC", 5M) { Balance = 100M });
			person2Wallet.Cards.Add(new Card("Visa", 10M) { Balance = 100M });

			Assert.AreEqual(person2.GetOwedInterest(), 15M);
			Assert.AreEqual(person2Wallet.GetOwedInterest(), 15M);
		}
	}
}
