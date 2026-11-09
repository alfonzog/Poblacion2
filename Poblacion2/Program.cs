namespace Poblacion2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<int> listaEdades = new List<int>();

      listaEdades.Add(10);
      listaEdades.Add(38);
      listaEdades.Add(0);
      listaEdades.Add(6);
      listaEdades.Add(15);
      listaEdades.Add(25);
      listaEdades.Add(80);
      listaEdades.Add(16);
      listaEdades.Add(43);

      int cuentaNinios = 0;
      int cuentaAdoles = 0;
      int cuentaAdultos = 0;
      int cuentaMaduros = 0;
      int cuentaAncianos = 0;
      int totalPoblacion = 0;

      float porcNinios = 0.0F;
      float porcAdoles = 0.0F;
      float porcAdultos = 0.0F;
      float porcMaduros = 0.0F;
      float porcAncianos = 0.0F;

      foreach (int edad in listaEdades)
      {
        if (edad >= 0 && edad <= 12)
        {
          cuentaNinios++;
        }
        if (edad >= 13 && edad <= 17)
        {
          cuentaAdoles++;
        }
        if (edad >= 18 && edad <= 39)
        {
          cuentaAdultos++;
        }
        if (edad >= 40 && edad <= 60)
        {
          cuentaMaduros++;
        }
        if (edad >= 61 && edad <= 120)
        {
          cuentaAncianos++;
        }
      }

      totalPoblacion = listaEdades.Count();
      porcNinios = (float)cuentaNinios / totalPoblacion * 100;
      porcAdoles = (float)cuentaAdoles / totalPoblacion * 100;
      porcAdultos = (float)cuentaAdultos / totalPoblacion * 100;
      porcMaduros = (float)cuentaMaduros / totalPoblacion * 100;
      porcAncianos = (float)cuentaAncianos / totalPoblacion * 100;

      Console.WriteLine(string.Format("{0:0.00}", porcNinios) + "% Niños");
      Console.WriteLine(string.Format("{0:0.00}", porcAdoles) + "% Adolescentes");
      Console.WriteLine(string.Format("{0:0.00}", porcAdultos) + "% Adultos Jóvenes");
      Console.WriteLine(string.Format("{0:0.00}", porcMaduros) + "% Maduros");
      Console.WriteLine(string.Format("{0:0.00}", porcAncianos) + "% Ancianos");

    }
  }
}
