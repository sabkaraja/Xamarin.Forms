namespace Xamarin.Platform.Handlers
{
	public partial class EntryHandler
	{
		public static PropertyMapper<IEntry> EntryMapper = new PropertyMapper<IEntry>(ViewHandler.ViewMapper)
		{
			[nameof(IText.Text)] = MapPropertyText,
			[nameof(IText.TextColor)] = MapPropertyColor,
			[nameof(IText.Font)] = MapPropertyFont,
			[nameof(IText.TextTransform)] = MapPropertyTextTransform,
			[nameof(IText.CharacterSpacing)] = MapPropertyCharacterSpacing,

			[nameof(ITextInput.Placeholder)] = MapPropertyPlaceholder,
			[nameof(ITextInput.PlaceholderColor)] = MapPropertyPlaceholderColor,
			[nameof(ITextInput.MaxLength)] = MapPropertyMaxLength,
			[nameof(ITextInput.IsReadOnly)] = MapPropertyIsReadOnly,
			[nameof(ITextInput.Keyboard)] = MapPropertyKeyboard,
			[nameof(ITextInput.IsSpellCheckEnabled)] = MapPropertyIsSpellCheckEnabled,

			[nameof(ITextAlignment.HorizontalTextAlignment)] = MapPropertyHorizontalTextAlignment,
			[nameof(ITextAlignment.VerticalTextAlignment)] = MapPropertyVerticalTextAlignment,

			[nameof(IFont.FontSize)] = MapPropertyFontSize,
			[nameof(IFont.FontAttributes)] = MapPropertyFontAttributes,

			[nameof(IEntry.IsPassword)] = MapPropertyIsPassword,
			[nameof(IEntry.ReturnType)] = MapPropertyReturnType,
			[nameof(IEntry.CursorPosition)] = MapPropertyCursorPosition,
			[nameof(IEntry.SelectionLength)] = MapPropertySelectionLength,
			[nameof(IEntry.IsTextPredictionEnabled)] = MapPropertyIsTextPredictionEnabled,
			[nameof(IEntry.ClearButtonVisibility)] = MapPropertyClearButtonVisibility,
		};

		public EntryHandler() : base(EntryMapper)
		{

		}

		public EntryHandler(PropertyMapper mapper) : base(mapper ?? EntryMapper)
		{

		}
	}
}
