using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PSAM_P10
{
    internal class Patineta : IVehiculoTerrestre, IVehiculoNoMotorizado
    {
        private int velocidad;
        private bool estacionada;
        private bool descansando;

        // Constructor
        public Patineta()
        {
            velocidad = 0;
            estacionada = true;
            descansando = true;
        }
        // Propiedades
        public int Velocidad
        {
            get { return velocidad; }
            private set { velocidad = value; }
        }
        public bool Estacionada
        {
            get { return estacionada; }
            private set { estacionada = value; }
        }

        public bool Descansando
        {
            get { return descansando; }
            private set { descansando = value; }
        }

        // Métodos
        public string Acelerar()
        {
            descansando = false;
            if (velocidad < 20)
            {
                velocidad += 5;
                return "Acelerando en la patineta...";
            }

            return "Fuiste demasiado rápido y descuidado, te han atropellado! :(.";
        }

        public string Frenar()
        {
            if (velocidad > 5)
            {
                velocidad -= 5;
                return "Frenando...";
            }
            
            if (velocidad > 0)
            {
                velocidad = 0;
                return "La patineta se ha detenido.";
            }

            return "Ya estás detenido.";
        }

        public int ObtenerVelocidad()
        {
            return velocidad;
        }

        public string Estacionar()
        {
            if (velocidad == 0)
            {
                estacionada = true;
                return "La patineta está estacionada.";
            }
            return "Debes detenerte antes de estacionar.";
        }

        public string HacerTruco()
        {
            if (velocidad > 0)
            {
                return "    ▓▓▓▓▓▓▓▓                              ██████████\n" +
                       "  ▓▓░░░░░░▓▓▓▓▓▓                        ██▒▒▒▒▒▒▒▒▒▒██\n" +
                       "  ░░▒▒    ░░▒▒▓▓▒▒▒▒▓▓▓▓                ██▓▓▒▒▒▒▒▒▒▒██\n" +
                       "    ▓▓    ░░▒▒▓▓▓▓▓▓████                ██▓▓▒▒▒▒▒▒▒▒██\n" +
                       "      ▓▓▓▓░░░░░░░░▓▓██▓▓████            ████▓▓▒▒▒▒  ██\n" +
                       "          ▓▓▓▓▓▓▓▓▓▓██    ░░████████████▒▒▓▓██████████                          ▓▓▓▓▓▓\n" +
                       "                  ▒▒▓▓░░▓▓░░            ▒▒▓▓██████████████████████████▓▓▓▓▓▓▓▓▓▓  ░░░░▓▓\n" +
                       "                    ████▓▓▒▒      ▓▓    ▓▓░░██▒▒▒▒▒▒▓▓            ▓▓██▓▓  ░░░░░░░░░░░░▓▓\n" +
                       "                      ████▓▓▒▒██  ▓▓      ▓▓██▒▒▒▒▒▒▓▓██    ██▓▓██▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n" +
                       "                          ▓▓▓▓▓▓████      ▒▒▒▒▓▓████▓▓░░██████████████\n" +
                       "                            ████▒▒██      ▓▓▓▓▓▓▓▓▓▓▓▓██████▓▓\n" +
                       "                              ██▒▒▓▓        ██▓▓▓▓▓▓▓▓████\n" +
                       "                                ▓▓██        ░░▓▓▓▓▓▓▒▒██▓▓\n" +
                       "                                ██▓▓          ▓▓████▒▒▒▒\n" +
                       "                                ██▓▓  ██▓▓      ▓▓▓▓▒▒▒▒\n" +
                       "                                ██▓▓▓▓        ▓▓▒▒▓▓████\n" +
                       "                                ████  ▓▓▓▓▒▒▒▒▓▓██▓▓▓▓██\n" +
                       "                                  ██▒▒▓▓  ▒▒██▓▓████████████\n" +
                       "                                  ██▒▒░░▒▒▒▒██████████████████\n" +
                       "                                ▓▓██▒▒  ██████████████████████\n" +
                       "                                ██████████████████████████▒▒██\n" +
                       "                              ██▓▓████████████████████████████\n" +
                       "                              ████████████████████████████████\n" +
                       "                              ██████████████      ██████████\n" +
                       "                            ██████████████        ██████████\n" +
                       "                            ████████████        ██████████▓▓\n" +
                       "                            ██████████          ████████\n" +
                       "                            ██████████      ░░▒▒▓▓██████\n" +
                       "                            ████████        ░░░░░░▒▒██  ██\n" +
                       "                          ▓▓██▒▒████        ▒▒░░▒▒▒▒██  ██\n" +
                       "                          ██████████        ░░░░▒▒████▓▓\n" +
                       "                          ██████████              ░░██\n" +
                       "                          ██████████              ▓▓▒▒\n" +
                       "                          ██████████            ▓▓░░▒▒\n" +
                       "                          ████████            ██  ▓▓▒▒\n" +
                       "                          ████████          ██\n" +
                       "                        ▒▒▒▒▓▓████        ██\n" +
                       "                        ░░░░░░▒▒██      ██\n" +
                       "                          ░░▒▒▒▒██    ██\n" +
                       "                        ▒▒  ▒▒████  ▓▓\n" +
                       "                                  ██\n" +
                       "                                ██▒▒\n" +
                       "                          ▓▓▓▓██░░▒▒\n" +
                       "                        ██████  ▓▓▒▒\n";
            }
            return "No puedes hacer trucos mientras estás estacionado.";
        }

        public string Descansar()
        {
            if (!descansando)
            {
                descansando = true;
                return "Te detuviste para descansar.";
            }
            return "Ya estás descansando.";
        }
    }
}