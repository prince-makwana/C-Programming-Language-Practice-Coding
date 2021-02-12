using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDemo
{
    public abstract class Car
    {
        // Constructor

        public Car()
        {
            Console.WriteLine("Constructor is called.");
        }

        public Car(int enginePower)
        {
            Console.WriteLine("Constructor is called with Parameterised Constructor.");
            _enginePower = enginePower;
        }
        //  Access Modifiers - Public, Private
        //private string _make;   //  Private member, can be accessed within class
        //private string _model;
        //private string _color;
        //private int _year;

        // Encapsulation - Providing access to private members through Public Properties

        //public string Make  //  Public Property no access restriction
        //{
        //    get
        //    {
        //        return _make;
        //    }
        //    set
        //    {
        //        _make = value;
        //    }
        //}

        //public string Model
        //{
        //    get { return _model; }
        //    set { _model = value; }
        //}

        //public int Year
        //{
        //    get { return _year; }
        //    set { _year = value; }
        //}

        //public string Color
        //{
        //    get { return _color; }
        //    set { _color = value; }
        //}

        private int _enginePower;

        public int Engine
        {
            get { return _enginePower; }
            set { _enginePower = value; }
        }

        public string Make { get; set; }    //  Public Property no access restriction

        public string Model { get; set; }

        public string Color { get; set; }

        public int Year { get; set; }

        public virtual void Run(int speed)
        {
            Console.WriteLine($"Car is running at speed {speed}");
        }

        public abstract void changeGear();
    }
}
