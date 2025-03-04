namespace LSP
{
    //LSP violates
    //<------------------------------------------>
    public class Rectangle
    {
        public virtual int width { get; set; }
        public virtual int height { get; set; }


        public int GetArea()
        {
            return width * height;
        }
    }
    //<------------------------------------------>


}
