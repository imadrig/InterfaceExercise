using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public double TrunkSize {get;set;}

        public string BodyStyle{ get; set; }

    }
}
