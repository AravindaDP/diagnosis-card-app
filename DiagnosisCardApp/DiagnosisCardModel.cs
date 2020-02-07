using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DiagnosisCardApp
{
    public enum Language
    {
        Sinhala,
        Tamil
    }

    public enum Sex
    {
        Male,
        Female
    }

    public enum AdmissionMode
    {
        Self,
        Referred,
        TransferedIn
    }

    public enum DischargeMode
    {
        Routine,
        TransferedOut,
        SelfDischarge
    }

    public class DiagnosisCardModel : ObservableObject
    {
        #region Fields

        private readonly string hospital;
        private readonly string ward;
        private string patientName;
        private string personalHealthNo;
        private string bhtNo;
        private uint age;
        private string bloodGroup;
        private DateTime admissionDate;
        private DateTime dischargeDate;
        private Language language;
        private Sex sex;
        private AdmissionMode admissionMode;
        private DischargeMode dischargeMode;
        private ObservableCollection<string> coMorbidities = new ObservableCollection<string>();
        private AllergiesModel allergies = new AllergiesModel();

        #endregion // Fields

        #region Properties

        public string Hospital
        {
            get { return hospital; }
        }

        public string Ward
        {
            get { return ward; }
        }

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

        public string PersonalHealthNo
        {
            get { return personalHealthNo; }
            set
            {
                if (value != personalHealthNo)
                {
                    personalHealthNo = value;
                    OnPropertyChanged("PersonalHealthNo");
                }
            }
        }

        public string BHTNo
        {
            get { return bhtNo; }
            set
            {
                if (value != bhtNo)
                {
                    bhtNo = value;
                    OnPropertyChanged("BHTNo");
                }
            }
        }

        public uint Age
        {
            get { return age; }
            set
            {
                if (value != age)
                {
                    age = value;
                    OnPropertyChanged("Age");
                }
            }
        }

        public string BloodGroup
        {
            get { return bloodGroup; }
            set
            {
                if (value != bloodGroup)
                {
                    bloodGroup = value;
                    OnPropertyChanged("BloodGroup");
                }
            }
        }

        public DateTime AdmissionDate
        {
            get { return admissionDate; }
            set
            {
                if (value != admissionDate)
                {
                    admissionDate = value;
                    OnPropertyChanged("AdmissionDate");
                }
            }
        }

        public DateTime DischargeDate
        {
            get { return dischargeDate; }
            set
            {
                if (value != dischargeDate)
                {
                    dischargeDate = value;
                    OnPropertyChanged("DischargeDate");
                }
            }
        }

        public Language Language
        {
            get { return language; }
            set
            {
                if (value != language)
                {
                    language = value;
                    OnPropertyChanged("Language");
                }
            }
        }

        public Sex Sex
        {
            get { return sex; }
            set
            {
                if (value != sex)
                {
                    sex = value;
                    OnPropertyChanged("Sex");
                }
            }
        }

        public AdmissionMode AdmissionMode
        {
            get { return admissionMode; }
            set
            {
                if (value != admissionMode)
                {
                    admissionMode = value;
                    OnPropertyChanged("AdmissionMode");
                }
            }
        }

        public DischargeMode DischargeMode
        {
            get { return dischargeMode; }
            set
            {
                if (value != dischargeMode)
                {
                    dischargeMode = value;
                    OnPropertyChanged("DischargeMode");
                }
            }
        }

        public ObservableCollection<string> CoMorbidities
        {
            get { return coMorbidities; }
            set
            {
                if (value != coMorbidities)
                {
                    coMorbidities = value;
                    OnPropertyChanged("CoMorbidities");
                }
            }
        }

        public AllergiesModel Allergies
        {
            get { return allergies; }
            set
            {
                if (value != allergies)
                {
                    allergies = value;
                    OnPropertyChanged("Allergies");
                }
            }
        }

        #endregion // Properties
    }
}
