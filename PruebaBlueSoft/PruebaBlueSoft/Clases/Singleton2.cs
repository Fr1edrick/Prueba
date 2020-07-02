namespace PruebaBlueSoft.Clases
{
  class Singleton2
  {
    public static Singleton2 Instance
    {
      get;
      private set;
    }

    public Singleton2()
    {
      Instance = new Singleton2();
    }
  }
}
