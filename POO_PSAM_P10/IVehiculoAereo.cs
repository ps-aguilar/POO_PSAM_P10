using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PSAM_P10
{
    internal interface IVehiculoAereo : IVehiculo
    {
        string Despegar();
        string Aterrizar();
    }
}
