using System.Collections.Generic;

namespace CodeChallenge06_GuessTheGifts.GiftAttributes
{
	public class SizeAttribute : GiftAttributeBase
	{
		/// <summary>
		/// Sets the size attribute to the given value
		/// </summary>
		/// <param name="selectedValue">Valid values are "small", "medium", "large"</param>
		public SizeAttribute(string selectedValue)
		{
			Name = "size";
			Values = new List<string> {"small", "medium", "large"};
			SetSelectedValue(selectedValue);
		}
	}
}