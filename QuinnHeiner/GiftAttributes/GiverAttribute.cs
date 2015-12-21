namespace CodeChallenge06_GuessTheGifts.GiftAttributes
{
	public class GiverAttribute : GiftAttributeBase
	{
		/// <summary>
		/// Sets the giver attribute to the given value
		/// </summary>
		/// <param name="selectedValue"></param>
		public GiverAttribute(string selectedValue)
		{
			Name = "giver";
			SetSelectedValue(selectedValue);
		}
	}
}