using System.Windows.Controls;
using System.Windows.Input;

using Augmentum.XGenos;

namespace Cafe.GitGuiPlatform.ViewModels
{
    public class PlayerSearchViewModel : ViewModelBase, IPlayerSearchViewModel
    {
        #region Public Fields
        public TextBox textBox { get; set; }

        public TextBox genderTextBox { get; set; }

        public TextBox houseStatusTextBox { get; set; }

        public TextBox areaStatusTextBox { get; set; }

        public ICommand ClickSearchCommand { get; set; }

        public ICommand BackToListCommand { get; set; }

        public ICommand FocusControlCommand { get; set; }

        public ICommand FocusGenderControlCommand { get; set; }

        public ICommand FocusHouseStatusCommand { get; set; }

        public ICommand FocusAreaStatusCommand { get; set; }

        public ICommand FocusNonTextBoxCommand { get; set; }

        #endregion

        #region Constructor
        public PlayerSearchViewModel()
        {
        }
        #endregion

        #region Public Methods
        public void Initialize()
        {
        }

        public void UpdateFocusControlCommand(TextBox tempTextBox)
        {
            textBox = tempTextBox;
        }

        public void GetFocusGenderControl(TextBox tempTextBox)
        {
            genderTextBox = tempTextBox;
        }

        public void GetFocusHouseStatusControl(TextBox tempTextBox)
        {
            houseStatusTextBox = tempTextBox;
        }

        public void GetAreaControl(TextBox tempTextBox)
        {
            areaStatusTextBox = tempTextBox;
        }
        #endregion
    }
}
