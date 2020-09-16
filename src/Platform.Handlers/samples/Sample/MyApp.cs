using Xamarin.Forms;
using Xamarin.Platform;
using Xamarin.Platform.Core;

namespace Sample
{
	public class MyApp : IApp
	{
		public MyApp()
		{
			Platform.Init();
		}

		public IView CreateView()
		{
			return new Entry { BackgroundColor = Color.Blue };
			/*
			return new Entry { Text = "Text" };
			return new Entry { Text = "TextTransform (Uppercase)", TextTransform = TextTransform.Uppercase };
			return new Entry { Text = "TextColor", TextColor = Color.OrangeRed };
			return new Entry { Placeholder = "Placeholder" };
			return new Entry { Placeholder = "PlaceholderColor", PlaceholderColor = Color.AliceBlue };
			return new Entry { Text = "FontAttributes", FontAttributes = FontAttributes.Bold };
			return new Entry { Text = "FontSize", FontSize = 24 };
			return new Entry { Text = "CharacterSpacing", BackgroundColor = Color.Blue, CharacterSpacing = 12 };
			return new Entry { Text = "HorizontalTextAlignment", HorizontalTextAlignment = TextAlignment.End };
			*/
		}
	}
}