namespace CarManagement
{
    class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CarColor { get; set; }
        public int Year { get; set; }

        public bool IsRented { get; set; }

        public double CarPrice { get; set; }
        public double CarRentPrice { get; set; }

        public Car(string brand, string model, string carColor, int year, double carPrice, bool isRented)
        {
            Brand = brand;
            Model = model;
            CarColor = carColor;
            Year = year;
            CarPrice = carPrice;
            IsRented = isRented;
        }

        public Car(string brand, string model, string carColor, int year, bool isRented, double carRentPrice)
        {
            Brand = brand;
            Model = model;
            CarColor = carColor;
            Year = year;
            CarRentPrice = carRentPrice;
            IsRented = isRented;
        }
    }
}
