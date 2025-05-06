namespace ExamenMITE_Empresa_Lider.Models
{
    public class Triangulo
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public double CalcularPerimetro()
        {
            return LadoA + LadoB + LadoC;
        }

        public double CalcularArea()
        {
            double s = (LadoA + LadoB + LadoC) / 2;

            // Validación: ¿Los lados forman un triángulo válido?
            if (LadoA + LadoB <= LadoC || LadoA + LadoC <= LadoB || LadoB + LadoC <= LadoA)
            {
                return double.NaN; // Retorna NaN si no es un triángulo válido
            }

            return Math.Sqrt(s * (s - LadoA) * (s - LadoB) * (s - LadoC));
        }
    }
}
