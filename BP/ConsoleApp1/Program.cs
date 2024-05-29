using BuilderPattern;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog.Builder()

           .SName("собака")
           .SBreed("Лобрадор")
           .SAge(300)
           .SToy("мяч")
           .SToy("кость")
           .Build();

            Console.WriteLine($"Имя: {dog.Name}");
            Console.WriteLine($"Порода: {dog.Breed}");
            Console.WriteLine($"Возраст: {dog.Age}");
            Console.WriteLine($"Игрушки: {string.Join(", ", dog.Toys)}");
        }
    }
}
