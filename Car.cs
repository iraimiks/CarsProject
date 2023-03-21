class Car
{
    public string color;
    public string model;
    public int year;

    public Car()
    {
        color = "red";
        model = "tesla";
        year = 2023;
    }
    public Car(string modelColor, string modelName, int modelYear)
    {
        color = modelColor;
        model = modelName;
        year = modelYear;
    }

    public void buyCar()
    {
        Console.WriteLine("Car is sell");
    }
}
