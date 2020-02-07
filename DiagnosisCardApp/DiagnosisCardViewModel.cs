using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ICommand checkBoxCommand;
        private ObservableCollection<CheckBoxViewModel> coMorbidities;

        #endregion

        public DiagnosisCardViewModel()
        {
            diagnosisCard = new DiagnosisCardModel();
            coMorbidities = new ObservableCollection<CheckBoxViewModel>();
            coMorbidities.Add(new CheckBoxViewModel("Diabetes"));
            coMorbidities.Add(new CheckBoxViewModel("Hypertension"));
            coMorbidities.Add(new CheckBoxViewModel("Hyperlipidemia"));
            coMorbidities.Add(new CheckBoxViewModel("Ischemic Heart Disease"));
            coMorbidities.Add(new CheckBoxViewModel("CKD"));
            coMorbidities.Add(new CheckBoxViewModel("Stroke"));
        }

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

        public ObservableCollection<CheckBoxViewModel> CoMorbidities
        {
            get { return coMorbidities; }
            set
            {
                if(value != coMorbidities)
                {
                    coMorbidities = value;
                    OnPropertyChanged("CoMorbidities");
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

        public ICommand CheckBoxCommand
        {
            get
            {
                if(checkBoxCommand == null)
                {
                    checkBoxCommand = new RelayCommand(
                        param => SelectListCheckBox(param)
                    );
                }
                return checkBoxCommand;
            }
        }

        public ObservableCollection<string> BloodGroups { get; } = new ObservableCollection<string>() { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };

        #endregion

        #region Private Helpers

        private void ClearInfo()
        {
            // You would implement your clear info function here
            DiagnosisCard = new DiagnosisCardModel();
        }

        private void SelectListCheckBox(object parameter)
        {
            var values = (object[])parameter;
            string name = (string)values[0];
            bool check = (bool)values[1];
            ObservableCollection<string> list = (ObservableCollection<string>)values[2];
            if (check)
            {
                list.Add(name);
            }
            else
            {
                list.Remove(name);
            }
        }

        #endregion

    }
}
