using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PSAM_P10
{
    internal class Helicoptero : IVehiculoAereo, IVehiculoMotorizado
    {
        private int velocidad;
        private bool encendido;
        private bool enVuelo;

        // Constructor
        public Helicoptero()
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
            return "Helicóptero encendido.";
        }

        public string Apagar()
        {
            if (enVuelo)
            {
                return "No se puede apagar el helicóptero mientras está en vuelo.";
            }

            encendido = false;
            velocidad = 0;
            enVuelo = false;
            return "Helicóptero apagado.";
        }

        public string Acelerar()
        {
            if (!encendido)
            {
                return "El helicóptero está apagado.";
            }

            velocidad += 30;

            if (velocidad >= 400)
            {
                velocidad = 400; 
                return "El helicóptero ha alcanzado su velocidad máxima.";
            }

            return "Acelerando...";
        }

        public string Frenar()
        {
            if (!encendido)
            {
                return "El helicóptero está apagado bro ._.";
            }

            if (velocidad >= 10)
            {
                velocidad -= 10;
            }

            if (velocidad > 0)
            {
                velocidad -= 1;
            }

            if (velocidad == 0)
            {
                return "El helicóptero se detuvo.";
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
                return "El helicóptero está apagado. Enciéndelo antes de despegar.";
            }

            if (velocidad < 200)
            {
                return "Acelera más para despegar.";
            }

            enVuelo = true;
            return "El helicóptero ha despegado.";
        }

        public string Aterrizar()
        {
            if (!enVuelo)
            {
                return "El helicóptero no está en vuelo.";
            }

            if (velocidad > 100)
            {
                return "Reduce la velocidad antes de aterrizar.";
            }

            enVuelo = false;
            velocidad = 0;
            return "El helicóptero ha aterrizado.";
        }
    }
}
