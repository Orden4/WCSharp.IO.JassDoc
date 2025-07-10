namespace WCSharp.IO.JassDoc.Output
{
	public class JassType : JassEntity
	{
		/// <summary>
		/// The type that this type extends.
		/// <para>Will be null if <c>void</c> (currently only ever the case in the unofficial <c>builtin-types.j</c> document).</para>
		/// </summary>
		public string? Extends { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}
