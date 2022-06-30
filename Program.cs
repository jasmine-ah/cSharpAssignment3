namespace cSharpAssignment3
{
    interface IShape
    {
        
        public double CalcPerimeter()
        {
            return 0.0;
        }
        public double CalcArea()
        {
            return 0.0;
        }
    }

    class Circle : IShape
    {
        static readonly double pi = 3.14;
        public double R { get; set; }

        public double CalcPerimeter()
        {
            double p = 2 * pi * R;
            return p;
        }
        public double CalcArea()
        {
            double area = pi * R * R;
            return area;
        }
        
    }
    class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Length { get; set; }
        
        public double CalcPerimeter()
        {
            double p = 2 * (Width + Length);
            return p;
        }
        public double CalcArea()
        {
            double area = Width * Length;
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new();
            c.R = 10;
            Rectangle r = new();
            r.Length = 20;
            r.Width = 35;
            Console.WriteLine("Area of the circle= " + c.CalcArea().ToString());
            Console.WriteLine("Perimeter of the circle= " + c.CalcPerimeter().ToString());
            Console.WriteLine("Area of the rectangle= " + r.CalcArea().ToString());
            Console.WriteLine("Perimeter of the rectangle= " + r.CalcPerimeter().ToString());

        }


    }

}

