using System.ComponentModel;

namespace DiagnosisCardApp
{
    public class DiagnosisCardModel : ObservableObject
    {
        #region Fields

        private string patientName;

        #endregion // Fields

        #region Properties

        public string PatientName
        {
            get { return patientName; }
            set
            {
                if (value != patientName)
                {
                    patientName = value;
                    OnPropertyChanged("PatientName");
                }
            }
        }

        #endregion // Properties
    }
}
