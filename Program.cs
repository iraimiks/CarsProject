namespace CarsProject;
class Program
{
    static void Main(string[] args)
    {
        Car carObj1 = new Car("red", "bmw", 2023);
        Car carObj2 = new Car("green", "audi", 2011);
        Car carObj3 = new Car("blue", "skoda", 2022);
        Car carObj4 = new Car();
        carObj1.buyCar();
        Console.WriteLine($"Car color: {carObj1.color} model name {carObj1.model}");
        Console.WriteLine(carObj2.color);
        Console.WriteLine(carObj3.color);
        Console.WriteLine($"Car color: {carObj4.color} model name {carObj4.model}");
    }
}
