namespace ClassLibrary
{
    public class Circle
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public bool IsPointInside(double x, double y)
        {
            double distanceSquared = x * x + y * y;
            double radiusSquared = Radius * Radius;

            return distanceSquared <= radiusSquared;
        }
    }
}
