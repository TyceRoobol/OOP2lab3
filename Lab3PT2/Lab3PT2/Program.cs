namespace Lab3PT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your dogs height: ");
            string dogHeight = Console.ReadLine();
            Console.WriteLine("What is your dogs name: ");
            string dogName = Console.ReadLine();
            Console.WriteLine("What is your dogs color: ");
            string dogColor = Console.ReadLine();
            Console.WriteLine("What is your dogs age: ");
            int dogAge = Convert.ToInt32(Console.ReadLine());
            Dog dog1 = new Dog(dogHeight, dogName, dogColor, dogAge);
            dog1.getInfo();
            dog1.Eat();
            Console.WriteLine(dog1.Cry());
            Console.WriteLine("what is your cats height: ");
            string catHeight = Console.ReadLine();
            Console.WriteLine("What is your cats name: ");
            string catName = Console.ReadLine();
            Console.WriteLine("What is your cats color: ");
            string catColor = Console.ReadLine();
            Console.WriteLine("What is your cats age: ");
            int catAge = Convert.ToInt32(Console.ReadLine());
            Cat cat1 = new Cat(catHeight, catName, catColor, catAge);
            cat1.getInfo();
            cat1.Eat();
            Console.WriteLine(cat1.Cry());
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(dog1);
            animals.Add(cat1);
            foreach (IAnimal obj in animals)
            {
                Console.WriteLine(obj.Name);
            }
        }
    }
}
