using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionConsola
{
    public class Principal
    {
        
        
       
        public void capturardatos()
        {

            int totalcentavos;
            int pesos;
            int centavos;
            
            Console.WriteLine("ingese totalcentavos: ");
            totalcentavos = Convert.ToInt32(Console.ReadLine());
            

            convertir(totalcentavos, out pesos, out centavos);
            Console.WriteLine("los centavos son: "+centavos);
            Console.WriteLine("los pesos son: " + pesos);
            Console.ReadKey();

        }

        public void convertir(int totalcentavos, out int pesos, out int centavos)
        {
            pesos = totalcentavos / 100;
            centavos = totalcentavos % 100;


        }

       
    }
}
