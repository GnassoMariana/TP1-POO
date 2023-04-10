namespace Circunferencia
{
    public class Circunferencia
    {
        public Circunferencia()
        {

        }

        public int Radio { get; set; }

        public Circunferencia( int radio )
        {
            Radio = radio;
        }

        public double GetRadio ()
        {
            return Radio;
        }

        public double GetArea ()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public double GetPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        int nuevoRadio = 0;

        public int CambiarRadio(nuevoRadio)
        {
            return Radio = nuevoRadio;
        }
    }
}