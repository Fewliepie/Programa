using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programa
{
    public class Documento
    {
        public int contador = 0;
        public void abrir()
        {
            Console.WriteLine("O documento não pussui caminho.");

        }
        public void abrir(string caminho)
        {
            if(File.Exists(caminho))
            {
              Console.WriteLine("O documento existe.");
              string[] texto = File.ReadAllLines(caminho);
              Console.WriteLine("Documento: ");
              foreach (string linhas in texto)
                {
                    contador++;
                }
              for(int i = 0; i < contador; i++)
              {
                Console.WriteLine(texto[i]);
              }
            }
            else
            {
                Console.WriteLine("O documento não existe.");
            }
        }    
    }
}