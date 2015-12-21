using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChallenge06_GuessTheGifts.GiftAttributes
{
	public abstract class GiftAttributeBase : IEquatable<GiftAttributeBase>
	{
		// properties
		public string Name { get; protected set; }
		public IEnumerable<string> Values { get; protected set; }
		public string SelectedValue { get; protected set; }

		// methods
		public bool ValidateSelectedValue()
		{
			// if no Values list exist, then don't enforce against a list
			return Values == null || Values.Contains(SelectedValue);
		}

		public void SetSelectedValue(string value)
		{
			SelectedValue = value.Trim();

			if (!ValidateSelectedValue())
			{
				throw new ArgumentException(string.Format("Invalid value ({0}) for {1}.  Valid values are {2}",
					value, GetType().Name, string.Join(",", Values)), "value");
			}
		}

		// objects are considered equal if their class name and selected value are equal
		public bool Equals(GiftAttributeBase other)
		{
			//Check whether the compared object is null.
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			//Check whether the compared object references the same data.
			if (ReferenceEquals(this, other))
			{
				return true;
			}

			//Check whether the products' properties are equal.
			return GetType().Name == other.GetType().Name && SelectedValue == other.SelectedValue;
		}

		// If Equals() returns true for a pair of objects 
		// then GetHashCode() must return the same value for these objects.
		public override int GetHashCode()
		{
			//Get hash code for the Name field if it is not null.
			var hashAttributeClassName = Name == null ? 0 : Name.GetHashCode();

			//Get hash code for the SelectedValue field.
			var hashSelectedValue = SelectedValue.GetHashCode();

			//Calculate the hash code for the attribute class.
			return hashAttributeClassName ^ hashSelectedValue;
		}
	}
}