using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan.Interfaces
{
    internal interface IVoertuig
    {
        int MaxSnelheid { get; }
        string Merk { get; }
        int Snelheid { get; }
        //Versnel(int versnelling);
        //vertraging
    }
}
