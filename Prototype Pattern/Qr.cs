namespace Prototype_Pattern
{
    public class Qr : ICopyEmmitter<Qr>
    {
        private int Code;

        public Qr GetCopy()
        {
            return new Qr() { Code = Code };
        }

        public static int Scan(Qr qr)
        {
            return qr.Code;
        }
    }
}