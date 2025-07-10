namespace WCSharp.IO.JassDoc.Parsing
{
	/// <summary>
	/// The target JassDoc to parse.
	/// </summary>
	/// <param name="Uri">The path or URL towards the JassDoc file.</param>
	/// <param name="FileName">The filename (e.g. common.j). Will use the last item of <see cref="Uri.Segments"/> if null.</param>
	public record JassDocTarget(Uri Uri, string? FileName = null);
}
