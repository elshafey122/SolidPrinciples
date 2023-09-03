namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var choice = 0;
            var pizza = new Pizza();
            do
            {
                choice=ReadChoice();
                if (choice>0&&choice<=6)
                {
                    Itopping topping = null;
                    switch (choice)
                    {
                        case 1:
                            topping = new Tomato();
                            break;
                        case 2:
                            topping = new Chicken();
                            break;
                        case 3:
                            topping = new Cheese();
                            break;
                        case 4:
                            topping = new BlackOlive();
                            break;
                        case 5:
                            topping = new GreenPaper();
                            break;
                        case 6:
                            topping = new Solami();
                            break;
                        default:
                            break;
                    }
                    pizza.addtopping(topping);
                    Console.WriteLine("Press any key to continue");
                }

            } while (choice != 0);

            Console.WriteLine(pizza);
        }
        private static int ReadChoice()
        {
            int choice=0;
            Console.WriteLine("Available Topping");
            Console.WriteLine("------------");
            Console.WriteLine("1. Tomato");
            Console.WriteLine("2. Chicken");
            Console.WriteLine("3. Cheese");
            Console.WriteLine("4. Black Olives");
            Console.WriteLine("5. Green Paper");
            Console.WriteLine("6. Solami");
            Console.WriteLine("0. exit");
            Console.WriteLine("select topping: ");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public class Pizza
        {
            public virtual decimal price => 10m;
            public List<Itopping> itopings { get; set; } = new List<Itopping>();
            public void addtopping(Itopping _itopings) => itopings.Add(_itopings);
            private decimal calculate()
            {
                decimal result = price;
                foreach (var item in itopings)
                {
                    result+=item.price;
                }
                return result;
            }
            public override string ToString()
            {
                var output = $"\n{nameof(Pizza)}";
                output += $" \n\tBase Price: ({price.ToString("C")})";
                foreach (var item in itopings)
                {
                    output += $"\n\t {item.title} ({item.price.ToString("C")})";
                }
                output += "\n-----------------------";
                output += $"\nTotal: {calculate().ToString("C")}";
                return output;
            }
        }
        public interface Itopping
        {
            public string title { get;}
            public decimal price { get;}
        }
        public class Tomato : Itopping
        {
            public string title => nameof(Tomato);

            public decimal price => 4m;
        }
        public class Chicken : Itopping
        {
            public string title => nameof(Chicken);

            public decimal price => 6m;
        }
        public class Cheese : Itopping
        {
            public string title => nameof(Cheese);

            public decimal price => 8m;
        }
        public class BlackOlive : Itopping
        {
            public string title => nameof(BlackOlive);

            public decimal price => 10m;
        }
        public class GreenPaper : Itopping
        {
            public string title => nameof(GreenPaper);

            public decimal price => 12m;
        }
        public class Solami : Itopping
        {
            public string title => nameof(Solami);

            public decimal price => 14m;
        }
    }
}