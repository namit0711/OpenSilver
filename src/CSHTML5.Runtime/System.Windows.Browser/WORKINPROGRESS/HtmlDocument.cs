#if WORKINPROGRESS

using System.Security;

namespace System.Windows.Browser
{
	public sealed partial class HtmlDocument
	{
		public HtmlElement Body { get; private set; }

		public HtmlElement CreateElement(string tagName)
		{
			return default(HtmlElement);
		}
		
		//
		// Summary:
		//     Gets a collection of browser elements.
		//
		// Parameters:
		//   tagName:
		//     A browser element's tag name.
		//
		// Returns:
		//     A collection of references to HTML elements that correspond to the requested
		//     tag name.
		//
		// Exceptions:
		//   T:System.ArgumentException:
		//     tagName is an empty string.
		//
		//   T:System.ArgumentNullException:
		//     tagName is null.
		//
		//   T:System.InvalidOperationException:
		//     An unexpected error occurred.
		[SecuritySafeCritical]
		public ScriptObjectCollection GetElementsByTagName(string tagName)
		{
			return default(ScriptObjectCollection);
		}
	}
}

#endif