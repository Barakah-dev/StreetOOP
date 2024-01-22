namespace StreetOOP.Street
{
    public class Owner
    {
        private string _name { get; set; }
        private string _occupation { get; set; }
        
        public Owner(string name, string occupation)
        {
            _name = name;
            _occupation = occupation;
        }        
    }
}
