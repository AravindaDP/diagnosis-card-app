using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DiagnosisCardApp
{
    public class DiagnosisCardViewModel : ObservableObject
    {
        #region Fields

        private DiagnosisCardModel diagnosisCard;
        private ICommand clearCommand;

        #endregion

        #region Public Properties/Commands

        public DiagnosisCardModel DiagnosisCard
        {
            get { return diagnosisCard; }
            set
            {
                if (value != diagnosisCard)
                {
                    diagnosisCard = value;
                    OnPropertyChanged("DiagnosisCard");
                }
            }
        }

        public ICommand ClearCommand
        {
            get
            {
                if (clearCommand == null)
                {
                    clearCommand = new RelayCommand(
                        param => ClearInfo()
                    );
                }
                return clearCommand;
            }
        }

        #endregion

        #region Private Helpers

        private void ClearInfo()
        {
            // You would implement your clear info function here
        }

        #endregion

    }
}
