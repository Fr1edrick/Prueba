namespace PruebaBlueSoft.Clases
{
  class Singleton4
  {
    private static Singleton4 _Instance;

    public static Singleton4 Instance
    {
      get
      {
        return _Instance != null ? _Instance : (_Instance = new Singleton4());
      }
    }

    private Singleton4() { }
  }
}
