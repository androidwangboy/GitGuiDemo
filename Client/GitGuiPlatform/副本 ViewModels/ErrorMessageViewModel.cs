using System.Windows.Input;

using Augmentum.XGenos;

namespace Cafe.GitGuiPlatform.ViewModels
{
    public class ErrorMessageViewModel : ViewModelBase, IErrorMessageViewModel
    {
        #region Public Fields
        public string Title { get; set; }
        public string Description { get; set; }
        public string ErrorCode { get; set; }
        public ICommand OkCommand { get; set; }
        #endregion

        #region Public Methods
        public void Initialize(string title, string description, string errorCode)
        {
            Title = title;
            Description = description;
            ErrorCode = errorCode;
        }

        public string ErrorCodeDisplay
        {
            get
            {
                return ErrorCode;
            }
        }
        #endregion
    }
}
