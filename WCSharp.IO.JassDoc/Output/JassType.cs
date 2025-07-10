namespace WCSharp.IO.JassDoc.Output
{
	/// <summary>
	/// A type specification as declared within Jass, e.g. <c>handle</c> or <c>unit</c>.
	/// </summary>
	public class JassType : JassEntity
	{
		/// <summary>
		/// The type that this type extends.
		/// <para>Will be null if <c>void</c> (currently only ever the case in the unofficial <c>builtin-types.j</c> document).</para>
		/// </summary>
		public string? Extends { get; set; }

		/// <inheritdoc/>
		public override string ToString()
		{
			return Name;
		}
	}
}
