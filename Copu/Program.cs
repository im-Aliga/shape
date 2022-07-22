using System;

namespace Copu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrilateral quad = new Quadrilateral(23, 34, 45, 67);
            Console.WriteLine(quad.Perimetr());

        }
        abstract class Shape
        {
            public abstract int Perimetr();
            public abstract int Area();









        }
        class Quadrilateral : Shape
        {
            public int Teref1 { get; set; }
            public int Teref2 { get; set; }
            public int Teref3 { get; set; }
            public int Teref4 { get; set; }
            public Quadrilateral(int teref1, int teref2, int teref3, int teref4)
            {

                Teref1 = teref1;
                Teref2 = teref2;
                Teref3 = teref3;
                Teref4 = teref4;
            }

            public override int Perimetr()
            {
                return Teref1 + Teref2 + Teref3 + Teref4;

            }

            public override int Area()
            {
                return Area();
            }



        }
        class Rectagle : Quadrilateral
        {

            public Rectagle(int teref1, int teref2)
               : base(teref1, teref2, teref1, teref2)
            {

                Teref1 = teref1;
                Teref2 = teref2;
            }
            public override int Perimetr()
            {
                return (Teref1 + Teref2) * 2;
            }

            public override int Area()
            {
                return Teref1 * Teref2;
            }


        }
        sealed class Square : Rectagle
        {
            public Square(int teref1)
                : base(teref1, teref1)
            {
                Teref1 = teref1;


            }
            public sealed override int Perimetr()
            {
                return Teref1 * 4;
            }

            public sealed override int Area()
            {
                return Teref1 * Teref1;
            }


        }

        sealed class Triangular : Shape
        {
            public int Teref1 { get; set; }
            public int Teref2 { get; set; }
            public int Teref3 { get; set; }
            public int Hundurluk { get; set; }


            public sealed override int Perimetr()
            {
                return Teref1 + Teref2 + Teref3;
            }

            public sealed override int Area()
            {
                return (Teref1 * Hundurluk) / 2;
            }


        }
        sealed class Circle : Shape
        {
            public int Radius { get; set; }


            public sealed override int Perimetr()
            {
                return 3 * 2 * Radius;
            }

            public sealed override int Area()
            {
                return 2 * 3 * (Radius * Radius);
            }




        }









    }
}

