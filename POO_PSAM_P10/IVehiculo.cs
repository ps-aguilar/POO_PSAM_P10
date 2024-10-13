using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PSAM_P10
{
    internal interface IVehiculo
    {
        string Acelerar();
        string Frenar();
        int ObtenerVelocidad();
    }
}
