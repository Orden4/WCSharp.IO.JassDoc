namespace WCSharp.IO.JassDoc.Output
{
	public class JassProperty : JassEntity
	{
		/// <summary>
		/// The type of the property.
		/// </summary>
		public string Type { get; set; } = null!;
		/// <summary>
		/// The value of the property, if present.
		/// </summary>
		public string? Value { get; set; }
		/// <summary>
		/// Whether the property is an array.
		/// </summary>
		public bool IsArray { get; set; }
		/// <summary>
		/// If the property is a constant.
		/// </summary>
		public bool IsConstant { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}
