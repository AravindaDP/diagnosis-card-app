using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosisCardApp
{
    public class CheckBoxViewModel : ObservableObject
    {
        #region Fields
        private string name;
        private bool isChecked;
        #endregion

        public CheckBoxViewModel(string name)
        {
            this.name = name;
        }

        #region Properties

        public string Name
        {
            get { return name; }
            set
            {
                if (value != name)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public bool IsChecked
        {
            get { return isChecked; }
            set
            {
                if (value != isChecked)
                {
                    isChecked = value;
                    OnPropertyChanged("IsChecked");
                }
            }
        }

        #endregion

    }
}
