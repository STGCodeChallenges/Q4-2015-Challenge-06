using System.Collections.Generic;
using System.Linq;

namespace CodeChallenge06_GuessTheGifts
{
	public static class GiftGuesser
	{
		// methods
		public static IEnumerable<string> GuessGifts(List<WishListItem> wishlist, List<Gift> gifts)
		{
			var matches = new List<string>();
			if (wishlist == null || gifts == null)
			{
				return matches;
			}

			// ReSharper disable once LoopCanBeConvertedToQuery
			foreach (var gift in gifts)
			{
				var matchingWishlistItems = GetMatchingWishlistItemsForGift(wishlist, gift);

				if (matchingWishlistItems != null)
				{
					matches.AddRange(matchingWishlistItems.Select(match => match.GiftName));
				}
			}

			return matches.Distinct();
		}

		private static IEnumerable<WishListItem> GetMatchingWishlistItemsForGift(IEnumerable<WishListItem> wishlist, Gift gift)
		{
			if (gift.Attributes == null || wishlist == null)
			{
				return null;
			}

			var giftAttributes = gift.Attributes.OrderBy(i => i.Name).ThenBy(i => i.SelectedValue);

			var matches = from wishListItem in wishlist
				let wishListAttributes = wishListItem.Attributes.OrderBy(i => i.Name).ThenBy(i => i.SelectedValue)
				where wishListAttributes.SequenceEqual(giftAttributes)
				select wishListItem;

			return matches;
		}
	}
}