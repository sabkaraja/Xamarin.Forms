using AppKit;

namespace Xamarin.Platform
{
	public interface INativeViewRenderer : IViewHandler
	{
		NSView? View { get; }
	}
}