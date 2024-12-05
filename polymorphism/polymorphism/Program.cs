using System;
public class Animal
{
    public virtual void eat()
    {
        Console.WriteLine("eating...");
    }
}
public class Dog : Animal
{
    public override void eat()
    {
        Console.WriteLine("EGG");
    }


}
public class Elephant : Animal
{
    public override void eat()
    {
        Console.WriteLine("Sugarcane");
    }


}
public class TestPolymorphism
{
    public static void Main()
    {
        Animal a = new Dog();
        a.eat();
        Animal b = new Elephant();
        b.eat();
    }
}
