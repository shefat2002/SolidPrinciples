namespace LSP.ShapeLSP
{
    public class Square : IShape
    {
        public double length { get; set; }
        public double getArea()
        {
            return length*length;
        }
    }

}
