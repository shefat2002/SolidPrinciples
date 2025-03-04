namespace LSP.ShapeLSP
{
    public class Rectangle :IShape
    {
        public double width { get; set; }
        public double height { get; set; }
        public double getArea()
        {
            return width * height;
        }
    }

}
