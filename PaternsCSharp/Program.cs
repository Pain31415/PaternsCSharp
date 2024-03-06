using PaternsCSharp.AbstractFactory;
using PaternsCSharp.Builder;
using PaternsCSharp.FabricMethod;
using PaternsCSharp.Prototype;
using PaternsCSharp.Singleton;

namespace PaternsCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            AnimalFactory animalFactory = new AnimalFactory();
            ClientLogic client = new ClientLogic(animalFactory);
            client.Run();
        }
        static void Main(string[] args)
        {
            PizzaDirector director = new PizzaDirector(new HawaiianPizzaBuilder());

            director.MakePizza();

            Pizza pizza = director.GetPizza();

            Console.WriteLine(pizza.ToString());
        }
        static void Main(string[] args)
        {
            CarFactory sedanFactory = new SedanCarFactory();
            Car sedan = sedanFactory.CreateCar();
            Console.WriteLine(sedan.GetInfo());

            CarFactory suvFactory = new SUVCarFactory();
            Car suv = suvFactory.CreateCar();
            Console.WriteLine(suv.GetInfo());
        }
        static void Main(string[] args)
        {
            AdminUser originalAdmin = new AdminUser { Username = "admin", Email = "admin@example.com" };
            originalAdmin.Display();
            AdminUser clonedAdmin = (AdminUser)originalAdmin.Clone();
            clonedAdmin.Username = "cloned_admin";
            clonedAdmin.Display();
        }
        static void Main(string[] args)
        {
            DatabaseConnection connection1 = DatabaseConnection.GetInstance();
            DatabaseConnection connection2 = DatabaseConnection.GetInstance();

            if (connection1 == connection2)
            {
                Console.WriteLine("connection1 та connection2 є тим самим екземпляром");
            }
            else
            {
                Console.WriteLine("connection1 та connection2 не є тим самим екземпляром");
            }
        }
    }
}
