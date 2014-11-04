
using System.Windows.Controls;
using System.Windows.Input;

using Augmentum.XGenos;

namespace Cafe.GitGuiPlatform.ViewModels
{
    public interface IPlayerSearchViewModel : IViewModel
    {
        void Initialize();

        void UpdateFocusControlCommand(TextBox tempTextBox);

        void GetFocusGenderControl(TextBox tempTextBox);

        void GetFocusHouseStatusControl(TextBox tempTextBox);

        void GetAreaControl(TextBox tempTextBox);

        ICommand ClickSearchCommand { get; set; }

        ICommand BackToListCommand { get; set; }

        ICommand FocusControlCommand { get; set; }

        ICommand FocusGenderControlCommand { get; set; }

        ICommand FocusHouseStatusCommand { get; set; }

        ICommand FocusAreaStatusCommand { get; set; }

        ICommand FocusNonTextBoxCommand { get; set; }

        TextBox textBox { get; set; }

        TextBox genderTextBox { get; set; }

        TextBox houseStatusTextBox { get; set; }

        TextBox areaStatusTextBox { get; set; }
    }
}