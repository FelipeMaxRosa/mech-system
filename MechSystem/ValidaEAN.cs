using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechSystem
{
  public class ValidaEAN
  {
    //Construtor
    public ValidaEAN()
    { 
    }

    //Métodos
    public string SomenteNumeros(string ean)
    {
      ean = ean.Trim();
      ean = ean.Replace("-", "");

      return ean;
    }

    public bool ValidarEAN(string ean)
    {
      bool resultado = false;
      if (ean.Length == 8 || ean.Length == 13)
      {
        int pares = 0, impares = 0;

        for (int i = 0; i <= (ean.Length - 2); i++)
        {
          if (i % 2 == 0)
          {
            impares += int.Parse(ean.Substring(i, 1));
          }
          else
          {
            pares += int.Parse(ean.Substring(i, 1));
          }
        }

        if (ean.Length == 13)
        {
          pares *= 3;
        }
        else
        {
          impares *= 3;
        }
        int checksum = pares + impares;
        int digitoControl = 10 - (checksum % 10);

        if (digitoControl == 10)
        {
          digitoControl = 0;
        }

        resultado = (digitoControl == int.Parse(ean.Substring(ean.Length - 1, 1)));
      }
      return resultado;
    }
  }
}
