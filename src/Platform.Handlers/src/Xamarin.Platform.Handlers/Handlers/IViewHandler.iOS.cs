using UIKit;

namespace Xamarin.Platform
{
	public interface INativeViewRenderer : IViewHandler
	{
		UIView? View { get; }
	}
}