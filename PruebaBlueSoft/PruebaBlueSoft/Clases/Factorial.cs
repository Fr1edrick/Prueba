namespace PruebaBlueSoft
{
  public class Factorial
  {
    public int CalculaFactorial(int i)
    {
      //TODO implementar la funcionalidad para el cálculo del factorial del número i
      // variable del resultado
      int result;
      // Casos base
      if (i == 0)
      {
        return 0;
      }
      else if (i == 1)
      {
        return 1;
      }
      return result = i * CalculaFactorial(i - 1);
    }
  }
}
