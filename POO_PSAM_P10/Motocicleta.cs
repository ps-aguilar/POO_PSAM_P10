using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PSAM_P10
{
    internal class Motocicleta : IVehiculoTerrestre, IVehiculoMotorizado
    {
        private int velocidad;
        private bool encendido;
        private bool estacionado;

        // Constructor
        public Motocicleta()
        {
            velocidad = 0;
            encendido = false;
            estacionado = true;
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

        public bool Estacionado
        {
            get { return estacionado; }
            private set { estacionado = value; }
        }

        // Métodos
        public string Encender()
        {
            encendido = true;
            return "Motocicleta encendida.";
        }

        public string Apagar()
        {
            if (!estacionado)
            {
                return "Estaciona la motocicleta antes de apagar.";
            }

            encendido = false;
            velocidad = 0;
            return "Motocicleta apagada.";
        }

        public string Acelerar()
        {
            if (!encendido)
            {
                return "La motocicleta está apagada.";
            }

            velocidad += 10;

            if (velocidad >= 150)
            {
                Apagar();
                return "Chale, tu motor murió >:c";
            }

            return "Acelerando...";
        }

        public string Frenar()
        {
            if (!encendido)
            {
                return "La motocicleta está apagada.";
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
                return "La motocicleta ya se detuvo.";
            }

            return "Frenando...";
        }

        public int ObtenerVelocidad()
        {
            return velocidad;
        }

        public string Estacionar()
        {
            if (!encendido)
            {
                return "La motocicleta está apagada. Enciéndela antes de estacionar.";
            }

            estacionado = true;
            velocidad = 0;
            return "La motocicleta está estacionada.";
        }
    }
}
