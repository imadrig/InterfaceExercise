using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
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

        //Car
        public double TrunkSize {get;set;} //cubic feet

        public string BodyStyle{ get; set; }

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
