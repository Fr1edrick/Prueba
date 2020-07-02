using PruebaBlueSoft.Clases;
using System;

namespace PruebaBlueSoft
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("PRUEBA");
      try
      {
        punto1();
        punto2();
        punto3();
        punto4();
      }
      catch (Exception er)
      {
        string ErMessage = "Error ocurred: " + er.Message;

        if (er.InnerException != null)
        {
          ErMessage += ErMessage + " Inner exception: " + er.InnerException.Message;
        }

        ErMessage = ErMessage + "Stack trace: " + er.StackTrace;

        Console.WriteLine("Error ocurred: " + er.StackTrace);

      }
    }

    static void punto1()
    {
      Tree tree1 = new Tree { leaves = 200 };
      Tree tree2 = tree1.doubleTreeLeaves(tree1);
      Console.WriteLine(tree1 == tree2);
      Console.WriteLine("tree1: " + tree1.leaves);
      Console.WriteLine("tree2: " + tree2.leaves);
    }

    static void punto2()
    {
      Pet myPet = new Cat();
      Cat johnsCat = new Cat();
      Ball ball = new Ball();

      Console.WriteLine(String.Format("My {0} is playing with a {1}. John's {2} is sleeping",
        myPet.Name, ball.GetName(), johnsCat.Name));
      //Console.ReadKey();
    }

    static void punto3()
    {
      bool testInstance = true;

      Singleton1 test11 = Singleton1.Instance;
      Singleton1 test12 = Singleton1.Instance;
      testInstance = (test11 == test12) ? true : false;
      Console.WriteLine("Instancia 1");
      Console.WriteLine("Las Intancias con iguales: " + testInstance);

      Singleton2 test21 = Singleton2.Instance;
      Singleton2 test22 = Singleton2.Instance;
      testInstance = (test21 == test22) ? true : false;
      Console.WriteLine("Instancia 2");
      Console.WriteLine("Las Intancias con iguales: " + testInstance);

      /* LA OPCIÓN TRES PRODUCE UN DESBORDAMIENTO Y ROMPE INMEDIATAMENTE*/
      //Singleton3 test31 = Singleton3.Instance;
      //Singleton3 test32 = Singleton3.Instance;
      //testInstance = (test31 == test32) ? true : false;
      //Console.WriteLine("Instancia 3");
      //Console.WriteLine("Las Intancias con iguales: " + testInstance);

      Singleton4 test41 = Singleton4.Instance;
      Singleton4 test42 = Singleton4.Instance;
      testInstance = (test41 == test42) ? true : false;
      Console.WriteLine("Instancia 4");
      Console.WriteLine("Las Intancias con iguales: " + testInstance);
    }

    static void punto4()
    {
      Factorial f = new Factorial();
      Console.Write("Input: ");
      int i = int.Parse(Console.ReadLine());

      if (i < 0)
      {
        Console.WriteLine($"Only value greater than 0, try again...");
      }
      else
      {
        int factorial = f.CalculaFactorial(i);
        Console.WriteLine($"El factorial del número {i} es {factorial}");
        Console.Read();
      }
    }
  }
}