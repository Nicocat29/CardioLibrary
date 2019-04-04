using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioLibrary
{
    public class DataCardio
    {
        public static void ValoriFrequenza(int battiticardiaci)
        {
            if (battiticardiaci<60)
            {
                Console.WriteLine("Bradicardia");
            }
            else if (battiticardiaci>=60 && battiticardiaci<=100)
            {
                Console.WriteLine("Normale");
            }
            else if (battiticardiaci>100)
            {
                Console.WriteLine("Tachicardia");
            }
           
        }
      
	

	}
        
    }

