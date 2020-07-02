namespace PruebaBlueSoft.Clases
{
  class Singleton1
  {
    private static Singleton1 _instance;

    public static Singleton1 Instance
    {
      get
      {
        return _instance == null ? new Singleton1() : _instance;
      }
    }
  }
}
