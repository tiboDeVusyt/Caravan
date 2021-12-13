using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan.Interfaces
{
    internal interface ITrekker
    {
        ITrekbaar Aanhangwagen { get; set; }
        int MaxTrekGewicht { get; set; }
        //static void KoppelAanhangWagen(ITrekbaar aanhangwagen)
        //{ 
        
        //}
    }
}
