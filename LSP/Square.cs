namespace LSP
{
    //LSP violates
    //<------------------------------------------>
    public class Square : Rectangle
    {
        public override int width { get => base.width; set => base.width = value; }
        public override int height { get => base.height; set => base.height = value; }

        public int GetArea()
        {
            return width * width;
        }
    }
    //<------------------------------------------>

}
