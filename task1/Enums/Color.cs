namespace task1.Enums
{
    public class Color
    {
        public static readonly Color Pink = new Color(255, 60, 0);
        
        public static readonly Color White = new Color(0, 0, 0);
        
        public int Red { get; private set; }
        
        public int Green { get; private set; }
        
        public int Blue { get; private set; }

        private Color(int red,  int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}