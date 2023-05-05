namespace Locust.Conversion
{
    public static class Conversion
    {
        public static IConversion Clr { get; set; }
        public static IConversion SqlClr { get; set; }
        static Conversion()
        {
            Clr = new SafeClrConvert();
            SqlClr = new SafeConvert();
        }
    }
}
