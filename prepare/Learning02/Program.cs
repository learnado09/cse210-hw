using System;
using System.Collections.Generic;

class Car
{
    public string _make;
    public string _model;
    public int _yearOfManufacture;
    public string _color;
}

class Garage
{
    public string _ownerName;
    public List<Car> _cars = new List<Car>();

    public void Display()
    {
        Console.WriteLine("Owner: " + _ownerName);
        foreach (var car in _cars)
        {
            Console.WriteLine("Car: " + car._make + " " + car._model + ", Year: " + car._yearOfManufacture + ", Color: " + car._color);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car();
        car1._make = "Toyota";
        car1._model = "Corolla";
        car1._yearOfManufacture = 2019;
        car1._color = "Red";

        Car car2 = new Car();
        car2._make = "Ford";
        car2._model = "Mustang";
        car2._yearOfManufacture = 2022;
        car2._color = "Blue";

        Garage myGarage = new Garage();
        myGarage._ownerName = "Allison Rose";

        myGarage._cars.Add(car1);
        myGarage._cars.Add(car2);

        myGarage.Display();
    }
}