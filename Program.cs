using StreetOOP.Street;

class Program
{
    static void Main(string[] args)
    {
        var street = new Street();
        StreetFlow(street);
    }

    static void StreetFlow(Street street)
    {
        while (true)
        {
          InitialDisplay();
                
          var stringOption = Console.ReadLine();
          var option = Int32.TryParse(stringOption, out int intOption);
          
          if (!option)
          {   
            Display(ConsoleColor.DarkRed, $"Error! Please insert a number");
          }
          else
          {
            if (intOption == 1)
            {  
                Display(ConsoleColor.DarkYellow, "Enter the name of the house you want to know its availability status");

                var houseName = Console.ReadLine();

                var houseAvailable = street.ConfirmIfAvailable(houseName);

                if (houseAvailable is true)
                {  
                    Display(ConsoleColor.DarkYellow, $"House with name {houseName}'s availablity is: {houseAvailable}. You can now proceed to rent this house");
                    
                }
                else if (houseAvailable is false)
                {  
                    Display(ConsoleColor.DarkRed, $"House with name {houseName}'s availablity is: {houseAvailable}, please check out other houses");
                }

            }
            else if (intOption == 2)
            {
              Display(ConsoleColor.DarkYellow, "Enter the name of the house you want to rent");

              var houseName = Console.ReadLine();
              var houseLeased = street.RentHouse(houseName);

              if (houseLeased)
              {
                Display(ConsoleColor.DarkRed, "System error, please try again");
                return;
              }
              else{
                Display(ConsoleColor.DarkGreen, $"Congaratulations! House '{houseName}' has now been leased to you, its availability to the others is now: {houseLeased}");
                return;
              }
            }
            else
            { 
              Display(ConsoleColor.DarkRed, $"Please start the process again and enter '1' or '2'");
            }
          }
        }

        
        

        // var street = new Street();
        // street.AddHouse(new House(new Owner("Tade", "Artisan"), "Empire", "Lilac", "Flat"));

        // var houseName = "Vine";
        // var houseAvailable = street.ConfirmIfAvailable(houseName);

        // Console.WriteLine($"House with name {houseName}'s availablity is: {houseAvailable}");

        // var houseRent = street.RentHouse(houseName);
        // Console.WriteLine($"Renting of house {houseName} made its availability: {houseRent}");
        // 
    }

    static void InitialDisplay()
    {
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine("Welcome to Blue-Orange Estate Agency. Please select one of the options below.");
      Console.ResetColor();
      Console.WriteLine("1. Confirm if a house is available");
      Console.WriteLine("2. Rent a house");
    }
    static void Display(ConsoleColor color, string message)
    {
      Console.Clear();
      Console.ForegroundColor = color;
      Console.WriteLine(message);
      Console.ResetColor();
    }
}