using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car 
            {   Year = "2002", 
                Make = "Porsche", 
                Model = "911", 
                NumberOfWheels = 4, 
                BodyStyle = "Coupe",
                TrunkSize = 4.4, //cubic feet
                CountryOfOrigin = "Germany",
                IsLuxuryBrand = true,
            };

            SUV suv1 = new SUV
            {
                Year = "2015",
                Make = "Ford",
                Model = "Explorer",
                NumberOfWheels = 4,
                CargoSize = 23.4, //cubic feet
                ThirdRowSeating = true,
                CountryOfOrigin = "United States",
                IsLuxuryBrand = false,
            };

            Truck truck1 = new Truck
            {
                Year = "2009",
                Make = "Chevrolet",
                Model = "Silverado",
                NumberOfWheels = 4,
                BedSize = 6.6, //feet
                TowingCapacity = 13300, //pounds
                CountryOfOrigin = "United States",
                IsLuxuryBrand = false,
            };

            Console.WriteLine("I have three vehicles in my garage.");

            Console.WriteLine();
            Console.Write($"My car is a {car1.Year} {car1.Make} {car1.Model} - {car1.BodyStyle} with {car1.NumberOfWheels} wheels. " +
                              $"Its trunk size is {car1.TrunkSize} cubic feet. " +
                              $"{car1.Make} is a {car1.LuxuryBrand(car1.IsLuxuryBrand)} company from {car1.CountryOfOrigin}.");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"My SUV is a {suv1.Year} {suv1.Make} {suv1.Model} with {car1.NumberOfWheels} wheels. " +
                              $"Its cargo size is {suv1.CargoSize} cubic feet. {suv1.HasThirdRowSeating(suv1.ThirdRowSeating)} " +
                              $"{suv1.Make} is a {suv1.LuxuryBrand(suv1.IsLuxuryBrand)} company from {truck1.CountryOfOrigin}.");
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"My truck is a {truck1.Year} {truck1.Make} {truck1.Model} with {truck1.NumberOfWheels} wheels. " +
                              $"Its bed size is {truck1.BedSize} feet and has a towing capacity of {truck1.TowingCapacity} pounds. " +
                              $"{truck1.Make} is a {truck1.LuxuryBrand(truck1.IsLuxuryBrand)} company from {truck1.CountryOfOrigin}.");


            #region Instructions 
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany - DONE

            //Create 3 classes called Car , Truck , & SUV - DONE

            //In your IVehicle - DONE

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany - DONE

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes - DONE

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members. - DONE 
             * 
             */

            //Now, create objects of your 3 classes and give their members values; - DONE
            //Creatively display and organize their values - DONE
            #endregion
        }
    }
}
