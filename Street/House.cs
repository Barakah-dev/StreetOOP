using System;

namespace StreetOOP.Street
{
    public class House
    {
        private Guid _houseNum { get; set; }
        private Owner _owner { get; set; }
        private string _houseName { get; set; }
        private string _color { get; set; }
        private string _type { get; set; }
        private bool _isAvailable { get; set; }

        public string HouseName()
        {
            return _houseName;
        }
        public bool IsAvailable()
        {
            return _isAvailable;
        }

        public House(Owner owner, string houseName, string color, string type)
        {
            _owner = owner;
            _houseName = houseName;
            _color = color;
            _type = type;
            _isAvailable = true;
        }       
    }
}
