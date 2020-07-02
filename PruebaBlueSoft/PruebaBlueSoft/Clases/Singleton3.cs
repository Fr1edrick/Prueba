namespace PruebaBlueSoft.Clases
{
  class Singleton3
  {
    private Singleton3 _Instance;

    public static Singleton3 Instance
    {
      get
      {
        return (new Singleton3())._Instance;
      }
    }

    public Singleton3()
    {
      _Instance = new Singleton3();
    }
  }
}
