using System;

class Program
{
    static void Main(string[] args)
    {
        // Inheritance and Method Overriding
        Animal myAnimal = new Animal();
        myAnimal.MakeSound();

        Dog myDog = new Dog();
        myDog.MakeSound();

        Cat myCat = new Cat();
        myCat.MakeSound();

        // Abstract Classes and Methods
        Shape myCircle = new Circle(5);
        Console.WriteLine($"Circle Area: {myCircle.GetArea()}");

        Shape myRectangle = new Rectangle(4, 5);
        Console.WriteLine($"Rectangle Area: {myRectangle.GetArea()}");

        // Interfaces
        IMovable myCar = new Car();
        myCar.Move();

        IMovable myBicycle = new Bicycle();
        myBicycle.Move();
    }
}