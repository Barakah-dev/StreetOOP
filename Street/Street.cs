using System;

namespace StreetOOP.Street
{
    public class Street
    {
        private IList<House> _houses;
        public Street()
        {
            _houses = new List<House>();
            _houses.Add(new House(new Owner("Ade", "Lawyer"), "Vine", "Blue", "Bungalow"));
            _houses.Add(new House(new Owner("Lola", "Nurse"), "Pearl", "Peach", "Duplex"));
            _houses.Add(new House(new Owner("Ola", "Teacher"), "WhiteLand", "White", "Duplex"));
            _houses.Add(new House(new Owner("Peju", "Doctor"), "Heritage", "Green", "Flat"));
            _houses.Add(new House(new Owner("Dele", "Engineer"), "Palace", "White", "Bungalow"));
        }

        public void AddHouse(House housetoAdd)
        {
            _houses.Add(housetoAdd);
        }

         public bool ConfirmIfAvailable(string houseName)
         {
            House houseToRent = _houses.FirstOrDefault(h => h.HouseName().ToLower() == houseName.ToLower() && h.IsAvailable());
            if (houseToRent is null)
            {
                return false;
            }
                return true;
         }
         public bool RentHouse(string houseName)
         {
            House houseToRent = _houses.FirstOrDefault(h => h.HouseName().ToLower() == houseName.ToLower() && h.IsAvailable());
            if (houseToRent is null)
            {
                houseToRent.IsAvailable();
                return true;
            }
                return false;
         }
    }
}
