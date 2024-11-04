using System;

    class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public const string CompanyName = "GOLD AUTO";

        public Car()
        {
            Name = "Невідомо";
            Color = "Невідомо";
            Price = 0;
        }

        public Car(string name, string color, double price)
        {
            Name = name;
            Color = color;
            Price = price;
        }

        public void Input()
        {
            Console.Write("Введіть назву автомобіля: ");
            Name = Console.ReadLine();
            Console.Write("Введіть колір автомобіля: ");
            Color = Console.ReadLine();
            Console.Write("Введіть ціну автомобіля: ");
            Price = double.Parse(Console.ReadLine());
        }

        // Метод для виведення даних про автомобіль на консоль
        public void Print()
        {
            Console.WriteLine($"Назва: {Name}");
            Console.WriteLine($"Колір: {Color}");
            Console.WriteLine($"Ціна: {Price} грн");
            Console.WriteLine($"Компанія: {CompanyName}");
        }

        // Метод для зміни ціни на x%
        public void ChangePrice(double x)
        {
            Price = Price * (1 - x / 100);
        }

        // Метод для зміни кольору автомобіля з кольором "white" на заданий
        public void Repaint(string newColor)
        {
            if (Color.ToLower() == "white")
            {
                Color = newColor;
            }
        }

        // Метод, який повертає інформацію про автомобіль у вигляді рядка
        public string PrintInfo()
        {
            return $"Назва: {Name}, Колір: {Color}, Ціна: {Price} грн, Компанія: {CompanyName}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car("Toyota", "White", 20000);
            Car car3 = new Car("Honda", "Red", 18000);

            Console.WriteLine("Введення даних для першого автомобіля:");
            car1.Input();

            car1.ChangePrice(10);
            car2.ChangePrice(10);
            car3.ChangePrice(10);

            Console.WriteLine("\nДані про автомобілі після зниження ціни:");
            car1.Print();
            Console.WriteLine();
            car2.Print();
            Console.WriteLine();
            car3.Print();

            Console.Write("\nВведіть новий колір для автомобілів із кольором 'white': ");
            string newColor = Console.ReadLine();

            car1.Repaint(newColor);
            car2.Repaint(newColor);
            car3.Repaint(newColor);

            Console.WriteLine("\nДані про автомобілі після зміни кольору:");
            Console.WriteLine(car1.PrintInfo());
            Console.WriteLine(car2.PrintInfo());
            Console.WriteLine(car3.PrintInfo());
        }
    }


