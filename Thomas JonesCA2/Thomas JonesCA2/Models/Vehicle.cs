// Thomas Jones - X00105989
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Thomas_JonesCA2.Models
{
    // enum to store vehicle category
    public enum Category
    {
        Car,
        [Display(Name = "Public Service Vehicle")]
        PublicVehicle, Bus, Goods
    }

    public class Vehicle
    {

        protected static Dictionary<Category, Double> dictonary = new Dictionary<Category, Double>();
        protected static int index = 0;
        protected static double[] prices = { 2.00, 2.00, 2.80, 4.10 };

        // Static constructor used for the dictonary
        static Vehicle()
        {
            // Iterate over the enum and populate the dictonary with <Category,Price>
            // because it is in a static constructor it will only ever run once
            foreach (Category a in Enum.GetValues(typeof(Category)))
            {
                dictonary.Add(a, prices[index]);
                index++;
            }
        }

        // VehicleType Field
        [Required(ErrorMessage = "Required Field")]
        [DisplayName("Vehicle Type")]
        public Category VehicleType { get; set; }

        // Tag Field
        [DisplayName("Electronic Tag")]
        public Boolean Tag { get; set; }


        // Calculate Cost Method
        [DataType(DataType.Currency)]
        [DisplayName("Toll Cost")]
        public double Cost
        {
            get
            {
                // Index into the Directory getting the selected Vehicle Type
                double cost = dictonary[this.VehicleType];

                // Deduct 20 % if vehicle has Toll Tag enabled
                if (Tag == true)
                {
                    cost -= cost * .20;
                }
                return cost;
            }
        }
    }
}