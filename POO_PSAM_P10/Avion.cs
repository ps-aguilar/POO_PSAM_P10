using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PSAM_P10
{
    internal class Avion : IVehiculoAereo, IVehiculoMotorizado
    {
        private int velocidad;
        private bool encendido;
        private bool enVuelo;

        // Constructor
        public Avion()
        {
            velocidad = 0;
            encendido = false;
            enVuelo = false;  
        }

        // Propiedades
        public int Velocidad
        {
            get { return velocidad; }
            private set { velocidad = value; }
        }

        public bool Encendido
        {
            get { return encendido; }
            private set { encendido = value; }
        }

        public bool EnVuelo
        {
            get { return enVuelo; }
            private set { enVuelo = value; }
        }

        // Métodos
        public string Encender()
        {
            encendido = true;
            return "Avión encendido.";
        }

        public string Apagar()
        {
            if (enVuelo)
            {
                return "No se puede apagar el avión mientras está en vuelo.";
            }

            encendido = false;
            velocidad = 0;
            enVuelo = false;
            return "Avión apagado.";
        }

        public string Acelerar()
        {
            if (!encendido)
            {
                return "El avión está apagado.";
            }

            velocidad += 50;

            if (velocidad >= 1000)
            {
                velocidad = 1000; 
                return "El avión ha alcanzado su velocidad máxima.";
            }

            return "Acelerando...";
        }

        public string Frenar()
        {
            if (!encendido)
            {
                return "El avión está apagado bro ._.";
            }

            if (velocidad >= 50)
            {
                velocidad -= 50;
            }

            if (velocidad > 0)
            {
                velocidad -= 10;
            }

            if (velocidad == 0)
            {
                return "El avión se detuvo.";
            }

            return "Frenando...";
        }

        public int ObtenerVelocidad()
        {
            return velocidad;
        }

        public string Despegar()
        {
            if (!encendido)
            {
                return "El avión está apagado. Enciéndelo antes de despegar.";
            }

            if (velocidad < 300)
            {
                return "Acelera más para despegar.";
            }

            enVuelo = true;
            return "El avión ha despegado.";
        }

        public string Aterrizar()
        {
            if (!enVuelo)
            {
                return "El avión no está en vuelo.";
            }

            if (velocidad > 200)
            {
                return "Reduce la velocidad antes de aterrizar.";
            }

            enVuelo = false;
            velocidad = 0;
            return "El avión ha aterrizado.";
        }
    }
}
