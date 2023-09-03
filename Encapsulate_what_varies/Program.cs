namespace Solid_Principles
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = Pizza.order(PizzaConstants.meat);
            Console.WriteLine(pizza);
        }
        public class Pizza
        {
            public virtual string title => $"{nameof(Pizza)}";
            public virtual decimal price => 10m;
            private static Pizza create(string type)
            {
                Pizza pizza;
                if (type.Equals(PizzaConstants.cheese))
                {
                    pizza = new Cheese();
                }
                else if (type.Equals(PizzaConstants.chicken))
                {
                    pizza = new Chicken();
                }
                else
                {
                    pizza = new meat();
                }
                return pizza;
            }
            public static Pizza order(string type)
            {
                Pizza pizza=  create(type);
                prepare();
                cook();
                cut();
                return pizza;
            }
            private static void prepare()
            {
                Console.WriteLine("preparing");
                Thread.Sleep(500);
                Console.WriteLine("completed");
            }
            private static void cook()
            {
                Console.WriteLine("cooking");
                Thread.Sleep(500);
                Console.WriteLine(" completed");
            }
            private static void cut()
            {
                Console.WriteLine("cutting");
                Thread.Sleep(500);
                Console.WriteLine(" completed");
            }
            public override string ToString()
            {
                return $"{title} ,price= {price}";
            }
        }
        public class Cheese : Pizza
        {
            public override string title => $"{base.title} {nameof(Cheese)}";
            public override decimal price => base.price+4m;
        }
        public class Chicken : Pizza
        {
            public override string title => $"{base.title} , {nameof(Chicken)}";
            public override decimal price => base.price + 6m;
        }
        public class meat : Pizza
        {
            public override string title => $"{base.title} , {nameof(meat)}";
            public override decimal price => base.price + 8m;
        }
    }
}