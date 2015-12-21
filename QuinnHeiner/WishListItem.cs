using System.Collections.Generic;
using CodeChallenge06_GuessTheGifts.GiftAttributes;

namespace CodeChallenge06_GuessTheGifts
{
	public class WishListItem
	{
		// properties
		public string GiftName { get; private set; }
		public IEnumerable<GiftAttributeBase> Attributes { get; private set; }

		// constructor
		public WishListItem(string giftName, IEnumerable<GiftAttributeBase> attributes)
		{
			GiftName = giftName;
			Attributes = attributes;
		}
	}
}