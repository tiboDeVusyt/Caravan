using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan.Interfaces
{
    internal interface IBewoonbaar
    {
        int AantalSlaapKamers { get; set; }
        double BewoonBaarOppervlakte { get; set; }
    }
}
