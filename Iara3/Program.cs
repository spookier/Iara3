using Iara3.Models;
class Program
{

    static void Main(string[] args)
    {

        List<Users> _userList = new List<Users>();
        List<Vehicles> _vehicleList = new List<Vehicles>();

 
        while (true)
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\tMAIN MENU");
            Console.WriteLine("\t 1 - REGISTER NEW USER");
            Console.WriteLine("\t 2 - REGISTER CAR");
            Console.WriteLine();
            Console.Write("\t Choose an option:");

            int key = Convert.ToInt32(Console.ReadLine());


            if (key == 1)
            {

                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\tREGISTERING USER");

                    Console.Write("\t Name of user: ");
                    String userName = Console.ReadLine();

                    Console.Write("\t Credit Card Number: ");
                    int CreditCard = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\t Your ViaVerde ID: ");
                    int IdentVV = Convert.ToInt32(Console.ReadLine());

                    Users user = new Users(userName, CreditCard, IdentVV);
                    _userList.Add(user);


                foreach (var item in _userList)
                {
                    Console.WriteLine(item.UserName);
                }

                key = 0;
            }
            else if (key == 2)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t \t VEHICLE MENU");
                Console.WriteLine();
                Console.WriteLine("\t 1 - Register a vehicle");
                Console.WriteLine("\t 2 - View owned vehicles");
                Console.WriteLine("\t 3 - Delete a vehicle");
                Console.WriteLine();

                key = Convert.ToInt32(Console.ReadLine());

                if (key == 1)
                {
                    Console.WriteLine("\t\tREGISTERING VEHICLE");

                    Console.Write("\t Model: ");
                    String Model = Console.ReadLine();

                    Console.Write("\t CarPlate: ");
                    String CarPlate = Console.ReadLine();

                    Console.Write("\t CarYear: ");
                    int CarYear = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\t CarClass: ");
                    String CarClass = Console.ReadLine();

                    Console.Write("\t IdentVV: ");
                    int IdentVV = Convert.ToInt32(Console.ReadLine());

                    Vehicles vehicle = new Vehicles(Model, CarPlate, CarYear, CarClass, IdentVV);
                    _vehicleList.Add(vehicle);

                    key = 0;
                    
                }

                if (key == 2)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t \t ALL VEHICLES");
                    Console.WriteLine();
                    foreach (var item in _vehicleList)
                    {
                        Console.WriteLine("Vehicle: " + item.Model);
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Press a key to continue");
                    Console.ReadKey();
                    
                }
            }
        }
    }
}