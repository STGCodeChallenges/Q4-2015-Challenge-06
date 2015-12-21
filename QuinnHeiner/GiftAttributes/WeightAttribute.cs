using System.Collections.Generic;

namespace CodeChallenge06_GuessTheGifts.GiftAttributes
{
	public class WeightAttribute : GiftAttributeBase
	{
		/// <summary>
		/// Sets the weight attribute to the given value
		/// </summary>
		/// <param name="selectedValue">Valid values are "light", "medium", "heavy"</param>
		public WeightAttribute(string selectedValue)
		{
			Name = "weight";
			Values = new List<string> {"light", "medium", "heavy"};
			SetSelectedValue(selectedValue);
		}
	}
}