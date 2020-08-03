using System;
namespace Lab10CirclesClass
{
    public class Circle
    {
        private double _radius;

        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value > 0)
                {
                    _radius = value;
                }
                else
                {
                    throw new Exception("Radius must be greater than 0! ");
                }
            }
        }

        public double CalculateCircumference()
        {
            return Math.PI * Radius * 2;
        }

        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }

        public double CalculateArea()
        {
            return Math.PI * (Radius * Radius);
        }

        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }

        private string FormatNumber(double x)
        {
            double numRounded = Math.Round(x, 2);
            return (numRounded.ToString());
        }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
