using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iara3.Models
{
    public class Vehicles
    {
        public String Model;
        private String CarPlate;
        private int CarYear;
        private String CarClass;
        private int IdentVV;
        private float Price;


        //ADD 3 CLASSES A B C and change PRICE 
        public Vehicles(string model, string carPlate, int carYear, string carClass, int identVV, float price = 10f)
        {
            Model = model;
            CarPlate = carPlate;
            CarYear = carYear;
            CarClass = carClass;
            IdentVV = identVV;
            //Price = price;
        }
    }
}
