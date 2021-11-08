using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Desenhando um circulo");
            base.Draw();
        }
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Desenhando um retangulo");
            base.Draw();
        }
    }
    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Desenhando um triangulo");
            base.Draw();
        }
    }
}

