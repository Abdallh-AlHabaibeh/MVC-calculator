using System.Data;

namespace Calculator.Services
{
    public class CalculatorService
    {
        public double Calculate(string expression)
        {
            DataTable table = new DataTable();

            var result = table.Compute(expression, "");

            return Convert.ToDouble(result);
        }
    }
}