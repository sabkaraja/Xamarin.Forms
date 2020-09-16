using Android.Graphics.Drawables;
using AView = Android.Views.View;

namespace Xamarin.Platform.Handlers
{
	public partial class ViewHandler
	{
		public static void MapPropertyIsEnabled(IViewHandler renderer, IView view)
		{
			if (renderer.NativeView is AView nativeView)
				nativeView.Enabled = view.IsEnabled;
		}

		public static void MapBackgroundColor(IViewHandler renderer, IView view)
		{
			if (!(renderer.NativeView is AView aview))
				return;

			var backgroundColor = view.BackgroundColor;

			if (backgroundColor.IsDefault)
				aview.Background = null;
			else
				aview.Background = new ColorDrawable { Color = backgroundColor.ToNative() };
		}
	}
}