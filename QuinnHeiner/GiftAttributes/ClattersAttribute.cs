using System.Collections.Generic;

namespace CodeChallenge06_GuessTheGifts.GiftAttributes
{
	public class ClattersAttribute : GiftAttributeBase
	{
		/// <summary>
		/// Sets the clatters attribute to the given value
		/// </summary>
		/// <param name="selectedValue">Valid values are "no", "a bit", "yes"</param>
		public ClattersAttribute(string selectedValue)
		{
			Name = "clatters";
			Values = new List<string> {"no", "a bit", "yes"};
			SetSelectedValue(selectedValue);
		}
	}
}