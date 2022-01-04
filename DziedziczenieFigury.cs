using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Shape
    {
        private int X, Y, Height, Width;

        public Shape(int X, int Y, int Height, int Width)
        {
            this.X = X;
            this.Y = Y;
            this.Height = Height;
            this.Width = Width;
        }

        public int X1 { get => X; set => X = value; }
        public int Y1 { get => Y; set => Y = value; }
        public int Height1 { get => Height; set => Height = value; }
        public int Width1 { get => Width; set => Width = value; }

        public virtual string Draw()
        {
            return "bezksztaltny!";
        }

    }

   class Rectangle : Shape
    {
        public Rectangle(int X, int Y, int Height, int Width) : base(X, Y, Height, Width) {}

        public override string Draw()
        {
            return ("wspolrzedna x: "+X1+ " wspolrzedna y: "+Y1 + " wysokosc: " + Height1 + " szerokosc: " + Width1);
        }
    }

    class Triangle : Shape
    {
        public Triangle(int X, int Y, int Height, int Width) : base(X, Y, Height, Width) {}

        public override string Draw()
        {
            return ("wspolrzedna x: " + X1 + " wspolrzedna y: " + Y1 + " wysokosc: " + Height1 + " szerokosc: " + Width1);
        }
    }
    class Circle : Shape
    {
        public Circle(int X, int Y, int Height, int Width) : base(X, Y, Height, Width) {}

        public override string Draw()
        {
            return ("wspolrzedna x: " + X1 + " wspolrzedna y: " + Y1 + " wysokosc: " + Height1 + " szerokosc: " + Width1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle prostko = new Rectangle(10,20,50,20);
            Triangle triadeczka = new Triangle(30, 15, 80, 200);
            Circle kolko = new Circle(5, 10, 50, 100);

            List<Shape> lista = new List<Shape>();
            lista.Add(prostko);
            lista.Add(triadeczka);
            lista.Add(kolko);

            foreach(Shape obiekt in lista)
            {
                Console.WriteLine(obiekt.Draw());
            }
        }
    }
}
