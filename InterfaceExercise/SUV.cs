using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        #region IVehicle
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
        #endregion

        #region ICompany
        public string CountryOfOrigin { get; set; }
        public bool IsLuxuryBrand { get; set; }
        #endregion


        //SUV
        public double CargoSize { get; set; } //cubic feet

        public bool ThirdRowSeating { get; set; }

        public string HasThirdRowSeating(bool thirdRowSeating)
        {
            if (ThirdRowSeating == true)
            {
                return "The SUV has third row seating.";
            }
            else
            {
                return "The SUV does not have third row seating.";
            }


        }

        public string LuxuryBrand(bool luxuryBrand)
        {
            if (IsLuxuryBrand == true)
            {
                return "luxury";
            }
            else
            {
                return "non-luxury";
            }
        }

    }

}
