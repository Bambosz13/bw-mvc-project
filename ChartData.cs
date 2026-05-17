namespace MvcProject.Models
{
    public class ChartData
    {
        public string[] Labels { get; set; }
        public int[] Values { get; set; }
        
        // Zmienna przechowująca wynik naszej "analizy danych" po stronie serwera
        public double AverageValue { get; set; } 
    }
}
