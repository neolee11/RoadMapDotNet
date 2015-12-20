using static System.Math;

namespace RoadMapDotNet.Code
{
    public class CSharp6Features
    {
        public int Num { get; set; } = 10;
        public int Something { get; set; }

        public int UsingStaticAbs(int i)
        {
            return Abs(i);
        }

        public int UsingAutoPropertyInitializer()
        {
            return Num;
        }
    }
}