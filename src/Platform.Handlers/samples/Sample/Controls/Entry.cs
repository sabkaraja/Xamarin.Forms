using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Platform;

namespace Sample
{
	public class Entry : View, IEntry
    {
        public Entry()
        {

        }

        public bool IsPassword { get; set; }

        public int MaxLength { get; set; } = int.MaxValue;

        public string Placeholder { get; set; }

        public Color PlaceholderColor { get; set; }

        public bool IsReadOnly { get; set; } = false;

        public string Text { get; set; }

        public Color TextColor { get; set; }

        public Font Font { get; set; }

        public TextTransform TextTransform { get; set; } = TextTransform.Default;

        public TextAlignment HorizontalTextAlignment { get; set; } = TextAlignment.Start;

        public TextAlignment VerticalTextAlignment { get; set; } = TextAlignment.Center;

        public double CharacterSpacing { get; set; }

        public FontAttributes FontAttributes { get; set; }

        public string FontFamily { get; set; }

        public double FontSize { get; set; }

        public ReturnType ReturnType { get; set; }

        public ICommand ReturnCommand { get; set; }

        public object ReturnCommandParameter { get; set; }

        public int CursorPosition { get; set; }

        public int SelectionLength { get; set; }

        public ClearButtonVisibility ClearButtonVisibility { get; set; }

        public Keyboard Keyboard { get; set; } = Keyboard.Default;

        public bool IsSpellCheckEnabled { get; set; } = true;

        public bool IsTextPredictionEnabled { get; set; } = true;

        public Action Completed { get; set; }

        void IEntry.Completed()
        {
            if (IsEnabled)
            {
                Completed?.Invoke();

                if (ReturnCommand != null && ReturnCommand.CanExecute(ReturnCommandParameter))
                {
                    ReturnCommand.Execute(ReturnCommandParameter);
                }
            }
        }
    }
}