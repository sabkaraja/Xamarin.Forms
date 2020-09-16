using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin.Platform
{
    public interface IEntry : ITextInput
    {
        bool IsPassword { get; }
        ReturnType ReturnType { get; }
        ICommand ReturnCommand { get; }
        object ReturnCommandParameter { get; }
        int CursorPosition { get; set; }
        int SelectionLength { get; set; }
        bool IsTextPredictionEnabled { get; }
        ClearButtonVisibility ClearButtonVisibility { get; }

        void Completed();
    }
}