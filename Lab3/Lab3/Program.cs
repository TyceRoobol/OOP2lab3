namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a dog name: ");
            string dogName = Console.ReadLine();
            Dog dog1 = new Dog(dogName, "Gray", 2);
            dog1.Eat();
            dog1.GetInfo();

            Console.WriteLine("please enter a cat name: ");
            string catName = Console.ReadLine();
            Cat cat1 = new Cat(catName, "White", 4);
            cat1.Eat();
            cat1.GetInfo(); 
        }
    }
}
