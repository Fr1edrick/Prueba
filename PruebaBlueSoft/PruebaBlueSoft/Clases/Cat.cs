using System;

namespace PruebaBlueSoft.Clases
{
  public class Cat : Pet
  {
    private String _Name = "cat";
    public override String Name
    {
      get
      {
        return _Name;
      }
    }
  }
}
