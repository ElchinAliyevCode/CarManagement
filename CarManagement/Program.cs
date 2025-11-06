using CarManagement;
Car car1 = new Car("BMW", "X5", "Black", 2009, true, 200);
Car car2 = new Car("Mercedes", "S-Class", "Black", 2012, true, 300);
Car car3 = new Car("Kia", "Optima", "Blue", 2015, true, 100);
Car car4 = new Car("Toyota", "Camry", "Gray", 2018, true, 200);
Car car5 = new Car("Hyundai", "Grandeur", "Black", 2018, true, 150);
Car car6 = new Car("Ford", "Mustang", "Red", 2012, 35000, false);
Car car7 = new Car("Honda", "Accord", "Yellow", 2020, 35000, false);
Car car8 = new Car("Lexus", "LX-300", "Black", 2020, 50000, false);
Car car9 = new Car("Audi", "A6", "Black", 2018, 36000, false);
Car car10 = new Car("BYD", "Destroyer 05", "Gray", 2025, 25000, false);

List<Car> cars = new List<Car>() { car1, car2, car3, car4, car5, car6, car7, car8, car9, car10 };

mainStart:
Console.WriteLine("Welcome to the Car Sales:");
Console.WriteLine("1. Car Sale");
Console.WriteLine("2. Rent a car");
Console.WriteLine("3. Bank");
Console.WriteLine("0. Exit");
Console.Write("Enter your choice: ");
int choice = Convert.ToInt32(Console.ReadLine());


start:
#region Car Sales

switch (choice)
{
    case 1:
        Console.WriteLine("You are now in car sale section !");
        Console.WriteLine("1. Add a car");
        Console.WriteLine("2. Display All Cars");
        Console.WriteLine("3. Remove a car");
        Console.WriteLine("4. Filter cars");
        Console.WriteLine("5. Sort cars");
        Console.WriteLine("6. Sale car");
        Console.WriteLine("0. Exit");
        Console.Write("Enter your choice: ");
        int saleInput = Convert.ToInt32(Console.ReadLine());
        switch (saleInput)
        {
            case 1:
                Console.Write("Enter car brand: ");
                string brand = Console.ReadLine();
                Console.Write("Enter car model: ");
                string model = Console.ReadLine();
                Console.Write("Enter car color: ");
                string color = Console.ReadLine();
                Console.Write("Enter car year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter car price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                Car newCar = new Car(brand, model, color, year, price, false);

                cars.Add(newCar);

                Console.WriteLine("Car added successfully!\n");

                Console.WriteLine("All Cars in Sale List:");
                foreach (var car in cars)
                {
                    if (!car.IsRented)
                        Console.WriteLine($"{car.Brand} {car.Model} - {car.CarColor} - {car.Year} - {car.CarPrice} AZN");
                }
                Console.WriteLine();
                goto start;
            case 2:
                Console.WriteLine("All Cars in Sale List:");
                foreach (var car in cars)
                {
                    if (!car.IsRented)
                        Console.WriteLine($"{car.Brand} {car.Model} - {car.CarColor} - {car.Year} - {car.CarPrice} AZN");
                }
                Console.WriteLine();
                goto start;
            case 3:
                Console.WriteLine("All Cars in Sale List:");
                foreach (var car in cars)
                {
                    if (!car.IsRented)
                        Console.WriteLine($"{car.Brand} {car.Model} - {car.CarColor} - {car.Year} - {car.CarPrice} AZN");
                }
                Console.WriteLine();

                var availableCars = cars.Where(car => car.IsRented == false).ToList();

                if (availableCars.Count == 0)
                {
                    Console.WriteLine("No cars found in a list !");
                }
                else
                {
                    Console.WriteLine("Available cars for removal:");
                    foreach (var car in availableCars)
                    {
                        Console.WriteLine($"ID: {car.Id} | {car.Brand} {car.Model} - {car.CarColor} - {car.Year} - {car.CarPrice} AZN");
                    }
                }

                Console.Write("Enter id to remove a car: ");
                int removeCarID = Convert.ToInt32(Console.ReadLine());

                var removedCar = cars.Find(car => car.Id == removeCarID && car.IsRented == false);

                if (removedCar != null)
                {
                    cars.Remove(removedCar);
                    Console.WriteLine($"Car found with ID {removeCarID} and removed successfully!\n");
                }
                else
                {
                    Console.WriteLine("Car is not found in a car sale list.");
                }

                goto start;
            case 4:
                Console.WriteLine("All Cars in Sale List:");
                foreach (var car in cars)
                {
                    if (!car.IsRented)
                        Console.WriteLine($"{car.Brand} {car.Model} - {car.CarColor} - {car.Year} - {car.CarPrice} AZN");
                }
                Console.WriteLine();

                Console.Write("Enter a year to filter cars: ");
                int yearForFilter = Convert.ToInt32(Console.ReadLine());

                var filteredCars = cars.FindAll(car => car.Year == yearForFilter);

                foreach (var car in filteredCars)
                {
                    if (!car.IsRented)
                        Console.WriteLine($"{car.Brand} {car.Model} - {car.CarColor} - {car.Year} - {car.CarPrice} AZN");
                }
                goto start;
            case 5:
                Console.WriteLine("All Cars in Sale List (Before Sorting):");
                foreach (var car in cars)
                {
                    if (!car.IsRented)
                        Console.WriteLine($"{car.Brand} {car.Model} - {car.CarColor} - {car.Year} - {car.CarPrice} AZN");
                }
                Console.WriteLine();

                List<Car> sortedCars = cars.Where(c => !c.IsRented).ToList();

                sortedCars.Sort((x, y) => x.CarPrice.CompareTo(y.CarPrice));

                Console.WriteLine("All Cars in Sale List (After Sorting by Price):");
                foreach (var car in sortedCars)
                {
                    Console.WriteLine($"{car.Brand} {car.Model} - {car.CarColor} - {car.Year} - {car.CarPrice} AZN");
                }
                Console.WriteLine();
                goto start;
            case 6:
                break;
            case 0:
                Console.WriteLine("Returned to the main menu...");
                goto mainStart;
            default:
                Console.WriteLine("Exitted from car sale section !");
                break;
        }
        break;
    case 2:
        Console.WriteLine("You are now in car sale section !");
        Console.WriteLine("1. Add a car");
        Console.WriteLine("2. Display All Cars");
        Console.WriteLine("3. Remove a car");
        Console.WriteLine("4. Filter cars");
        Console.WriteLine("5. Sort cars");
        Console.WriteLine("6. Rent a car");
        Console.WriteLine("0. Exit");
        int rentInput = Convert.ToInt32(Console.ReadLine());
        switch (rentInput)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 0:
                Console.WriteLine("Returned to the main menu...");
                goto start;
            default:
                Console.WriteLine("Exitted from rent a car section !");
                break;
        }
        break;
    case 3:
        Console.WriteLine("You are now in bank section !");
        Console.WriteLine("1. Bank Account");
        Console.WriteLine("2. Transactions");
        Console.WriteLine("0. Exit");
        int bankInput = Convert.ToInt32(Console.ReadLine());
        switch (bankInput)
        {
            case 1:
                break;
            case 2:
                break;
            case 0:
                Console.WriteLine("Returned to the main menu...");
                goto start;
            default:
                Console.WriteLine("Exitted from bank section !");
                break;
        }
        break;
    case 0:
        Console.WriteLine("Exitting...");
        goto mainStart;
    default:
        Console.WriteLine("Invalid option. Please try again !");
        break;
}

#endregion

#region Bank

#endregion

#region Rent a Car

#endregion
