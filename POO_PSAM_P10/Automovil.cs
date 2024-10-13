using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PSAM_P10
{
    internal class Automovil : IVehiculoTerrestre, IVehiculoMotorizado
    {
        private int velocidad;
        private bool encendido;
        private bool estacionado;

        // Constructor
        public Automovil()
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
            return "Automóvil encendido";
        }

        public string Apagar()
        {
            if (!encendido)
            {
                return "El automóvil ya estaba apagadop ._.";
            }

            if (!estacionado)
            {
                return "Estaciona el automóvil antes de apagar.";
            }
            
            encendido = false;
            velocidad = 0;
            return "Automóvil apagado.";
        }
        public string Acelerar()
        {
            if (!encendido)
            {
                return "El automóvil está apagado.";
            }

            estacionado = false;
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
                return "El automóvil está apagado bro ._.";
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
                return "El automóvil se detuvo.";
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
                return "El automóvil está apagado. Enciéndelo antes de estacionar.";
            }

            estacionado = true; 
            velocidad = 0; 
            return "El automóvil está estacionado.";
        }
    }
}
