using static System.Math;

namespace RoadMapDotNet.Code
{
    public class CSharp6Features
    {
        public int Num { get; set; } = 10;

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