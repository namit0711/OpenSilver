
/*===================================================================================
* 
*   Copyright (c) Userware/OpenSilver.net
*      
*   This file is part of the OpenSilver Runtime (https://opensilver.net), which is
*   licensed under the MIT license: https://opensource.org/licenses/MIT
*   
*   As stated in the MIT license, "the above copyright notice and this permission
*   notice shall be included in all copies or substantial portions of the Software."
*  
\*====================================================================================*/

using System.Windows.Automation.Provider;

namespace System.Windows.Automation
{
	/// <summary>
	/// Contains values used as automation property identifiers specifically for properties
	/// of the <see cref="IMultipleViewProvider"/> pattern.
	/// </summary>
	public static class MultipleViewPatternIdentifiers
	{
		/// <summary>
		/// Identifies the <see cref="IMultipleViewProvider.CurrentView"/> automation property.
		/// </summary>
		/// <returns>
		/// The automation property identifier.
		/// </returns>
		public static readonly AutomationProperty CurrentViewProperty =
			AutomationProperty.Register(
				AutomationIdentifierConstants.Properties.MultipleViewCurrentView,
				"MultipleViewPatternIdentifiers.CurrentViewProperty");

		/// <summary>
		/// Identifies the automation property that gets the control-specific collection of views.
		/// </summary>
		/// <returns>
		/// The automation property identifier.
		/// </returns>
		public static readonly AutomationProperty SupportedViewsProperty =
			AutomationProperty.Register(
				AutomationIdentifierConstants.Properties.MultipleViewSupportedViews,
				"MultipleViewPatternIdentifiers.SupportedViewsProperty");
	}
}
