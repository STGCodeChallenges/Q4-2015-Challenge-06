using System.Collections.Generic;
using CodeChallenge06_GuessTheGifts.GiftAttributes;

namespace CodeChallenge06_GuessTheGifts
{
	public class Gift
	{
		// properties
		public IEnumerable<GiftAttributeBase> Attributes { get; private set; }

		// constructor
		public Gift(IEnumerable<GiftAttributeBase> attributes)
		{
			Attributes = attributes;
		}
	}
}