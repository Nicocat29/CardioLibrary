using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioLibrary
{
    public class DataCardio
    {
        public static string ValoriFrequenza(int battiticardiaci)
        {
            if (battiticardiaci < 60 && battiticardiaci > 0)
            {
                return "Bradicardia";
            }
            else if (battiticardiaci >= 60 && battiticardiaci <= 100)
            {
                return "Normale";
            }
            else if (battiticardiaci > 100)
            {
                return "Tachicardia";
            }
            else
            {
                return "impossibile";
            }
           
        }
      
	

	}
        
    }

