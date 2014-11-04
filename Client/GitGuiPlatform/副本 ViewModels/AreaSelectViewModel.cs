using System.Collections.Generic;
using System.Windows.Input;

using Augmentum.XGenos;

namespace Cafe.GitGuiPlatform.ViewModels
{
    public class AreaSelectViewModel : ViewModelBase, IAreaSelectViewModel
    {
        #region Private Fields
        private List<string> AreaList { get; set; }
        #endregion
        
        #region Public Fields
        public ICommand SelectAreaCommand { get; set; }
        #endregion

        #region Default Constructor
        public AreaSelectViewModel()
        {
        }
        #endregion

        #region Public Methods
        public void Initialize()
        {
            AreaList = new List<string>();
            AreaList.Add("ShangHai");
            AreaList.Add("GuangZhou");
            AreaList.Add("BeiJing");
            AreaList.Add("HeNan");
            AreaList.Add("HeBei");
            AreaList.Add("London");
            AreaList.Add("ChengDu");
            AreaList.Add("ShenZhen");
        }
        #endregion
    }
}
