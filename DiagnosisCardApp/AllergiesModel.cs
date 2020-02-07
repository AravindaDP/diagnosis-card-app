using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosisCardApp
{
    public class AllergiesModel : ObservableObject
    {
        #region Fields
        private bool foodAllergy;
        private bool drugAllergy;
        private bool plasterAllergy;
        #endregion

        #region Properties

        public bool FoodAllergy
        {
            get { return foodAllergy; }
            set
            {
                if (value != foodAllergy)
                {
                    foodAllergy = value;
                    OnPropertyChanged("FoodAllergy");
                }
            }
        }

        public bool DrugAllergy
        {
            get { return drugAllergy; }
            set
            {
                if (value != drugAllergy)
                {
                    drugAllergy = value;
                    OnPropertyChanged("DrugAllergy");
                }
            }
        }

        public bool PlasterAllergy
        {
            get { return plasterAllergy; }
            set
            {
                if (value != plasterAllergy)
                {
                    plasterAllergy = value;
                    OnPropertyChanged("PlasterAllergy");
                }
            }
        }

        #endregion

        public override string ToString()
        {
            string food = FoodAllergy ? "F+" : "F0";
            string drug = drugAllergy ? "D+" : "D0";
            string plaster = plasterAllergy ? "P+" : "P0";
            return String.Format("{0}, {1}, {2}", food, drug, plaster);
        }

    }
}
