using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace POO_PSAM_P10
{
    internal class InterfazUsuario
    {
        List<Opcion> opcionesPrincipal;
        Menu menuPrincipal;
        bool dentroMenuPrincipal = true;

        public InterfazUsuario()
        {
            opcionesPrincipal = new List<Opcion>()
            {
                new Opcion("Automóvil", Automovil),
                new Opcion("Motocicleta", Motocicleta),
                new Opcion("Bicicleta", Bicicleta),
                new Opcion("Patineta", Patineta),
                new Opcion("Avión", Avion),
                new Opcion("Helicóptero", Helicoptero),
                new Opcion("Salir", Salir),
            };


            menuPrincipal = new Menu("Menú Principal", opcionesPrincipal);

            while (dentroMenuPrincipal)
            {
                menuPrincipal.MostrarMenu();
                int opcion = menuPrincipal.SeleccionarOpcion();
                opcionesPrincipal[opcion - 1].Action.Invoke();
            }
        }

        /// Metodos de vehiculos
        public void Automovil()
        {
            Automovil automovil = new Automovil(); // Crear instancia de Automovil
            bool dentroMenuAutomovil = true;

            List<Opcion> opcionesAutomovil = new List<Opcion>
            {
                new Opcion("Encender", () => Console.WriteLine(automovil.Encender())),
                new Opcion("Acelerar", () => Console.WriteLine(automovil.Acelerar())),
                new Opcion("Frenar", () => Console.WriteLine(automovil.Frenar())),
                new Opcion("Ver Velocidad", () => Console.WriteLine("Velocidad actual: {0} km/h", automovil.ObtenerVelocidad())),
                new Opcion("Estacionar", () => Console.WriteLine(automovil.Estacionar())),
                new Opcion("Apagar", () => Console.WriteLine(automovil.Apagar())),
                new Opcion("Regresar a Menú Principal", () => { dentroMenuAutomovil = false; RegresarPrincipal();}),
            }; 

            Menu menuAutomovil = new Menu("Menú del Automóvil", opcionesAutomovil);

            while (dentroMenuAutomovil) 
            {
                menuAutomovil.MostrarMenu();
                int opcion = menuAutomovil.SeleccionarOpcion();
                Console.WriteLine();
                opcionesAutomovil[opcion - 1].Action.Invoke();
                menuAutomovil.Continuar();
            }
        }

        public void Motocicleta()
        {
            Motocicleta motocicleta = new Motocicleta();
            bool dentroMenuMotocicleta = true;

            List<Opcion> opcionesMotocicleta = new List<Opcion>
            {
                new Opcion("Encender", () => Console.WriteLine(motocicleta.Encender())),
                new Opcion("Acelerar", () => Console.WriteLine(motocicleta.Acelerar())),
                new Opcion("Frenar", () => Console.WriteLine(motocicleta.Frenar())),
                new Opcion("Ver Velocidad", () => Console.WriteLine("Velocidad actual: {0} km/h", motocicleta.ObtenerVelocidad())),
                new Opcion("Estacionar", () => Console.WriteLine(motocicleta.Estacionar())),
                new Opcion("Apagar", () => Console.WriteLine(motocicleta.Apagar())),
                new Opcion("Regresar a Menú Principal", () => { dentroMenuMotocicleta = false; RegresarPrincipal(); }),
            };

            Menu menuMotocicleta = new Menu("Menú de Motocicleta", opcionesMotocicleta);

            while (dentroMenuMotocicleta)
            {
                menuMotocicleta.MostrarMenu();
                int opcion = menuMotocicleta.SeleccionarOpcion();
                Console.WriteLine();
                opcionesMotocicleta[opcion - 1].Action.Invoke();
                menuMotocicleta.Continuar();
            }
        }

        public void Bicicleta()
        {
            Bicicleta bicicleta = new Bicicleta();
            bool dentroMenuBicicleta = true;

            List<Opcion> opcionesBicicleta = new List<Opcion>
            {
                new Opcion("Acelerar", () => Console.WriteLine(bicicleta.Acelerar())),
                new Opcion("Frenar", () => Console.WriteLine(bicicleta.Frenar())),
                new Opcion("Ver Velocidad", () => Console.WriteLine("Velocidad actual: {0} km/h", bicicleta.ObtenerVelocidad())),
                new Opcion("Estacionar", () => Console.WriteLine(bicicleta.Estacionar())),
                new Opcion("Hacer Truco", () => Console.WriteLine(bicicleta.HacerTruco())),
                new Opcion("Descansar", () => Console.WriteLine(bicicleta.Descansar())),
                new Opcion("Regresar a Menú Principal", () => { dentroMenuBicicleta = false; RegresarPrincipal(); }),
            };

            Menu menuBicicleta = new Menu("Menú de Bicicleta", opcionesBicicleta);

            while (dentroMenuBicicleta)
            {
                menuBicicleta.MostrarMenu();
                int opcion = menuBicicleta.SeleccionarOpcion();
                Console.WriteLine();
                opcionesBicicleta[opcion - 1].Action.Invoke();
                menuBicicleta.Continuar();
            }
        }

        public void Patineta()
        {
            Patineta patineta = new Patineta();
            bool dentroMenuPatineta = true;

            List<Opcion> opcionesPatineta = new List<Opcion>
            {
                new Opcion("Acelerar", () => Console.WriteLine(patineta.Acelerar())),
                new Opcion("Frenar", () => Console.WriteLine(patineta.Frenar())),
                new Opcion("Ver Velocidad", () => Console.WriteLine("Velocidad actual: {0} km/h", patineta.ObtenerVelocidad())),
                new Opcion("Estacionar", () => Console.WriteLine(patineta.Estacionar())),
                new Opcion("Hacer Truco", () => Console.WriteLine(patineta.HacerTruco())),
                new Opcion("Descansar", () => Console.WriteLine(patineta.Descansar())),
                new Opcion("Regresar a Menú Principal", () => { dentroMenuPatineta = false; RegresarPrincipal(); }),
            };

            Menu menuPatineta = new Menu("Menú de Patineta", opcionesPatineta);

            while (dentroMenuPatineta)
            {
                menuPatineta.MostrarMenu();
                int opcion = menuPatineta.SeleccionarOpcion();
                Console.WriteLine();
                opcionesPatineta[opcion - 1].Action.Invoke();
                menuPatineta.Continuar();
            }
        }

        public void Avion()
        {
            Avion avion = new Avion();
            bool dentroMenuAvion = true;

            List<Opcion> opcionesAvion = new List<Opcion>
            {
                new Opcion("Encender", () => Console.WriteLine(avion.Encender())),
                new Opcion("Acelerar", () => Console.WriteLine(avion.Acelerar())),
                new Opcion("Frenar", () => Console.WriteLine(avion.Frenar())),
                new Opcion("Ver Velocidad", () => Console.WriteLine("Velocidad actual: {0} km/h", avion.ObtenerVelocidad())),
                new Opcion("Despegar", () => Console.WriteLine(avion.Despegar())),
                new Opcion("Aterrizar", () => Console.WriteLine(avion.Aterrizar())),
                new Opcion("Apagar", () => Console.WriteLine(avion.Apagar())),
                new Opcion("Regresar a Menú Principal", () => { dentroMenuAvion = false; RegresarPrincipal(); }),
            };

            Menu menuAvion = new Menu("Menú de Avión", opcionesAvion);

            while (dentroMenuAvion)
            {
                menuAvion.MostrarMenu();
                int opcion = menuAvion.SeleccionarOpcion();
                Console.WriteLine();
                opcionesAvion[opcion - 1].Action.Invoke();
                menuAvion.Continuar();
            }
        }

        public void Helicoptero()
        {
            Helicoptero helicoptero = new Helicoptero();
            bool dentroMenuHelicoptero = true;

            List<Opcion> opcionesHelicoptero = new List<Opcion>
            {
                new Opcion("Encender", () => Console.WriteLine(helicoptero.Encender())),
                new Opcion("Acelerar", () => Console.WriteLine(helicoptero.Acelerar())),
                new Opcion("Frenar", () => Console.WriteLine(helicoptero.Frenar())),
                new Opcion("Ver Velocidad", () => Console.WriteLine("Velocidad actual: {0} km/h", helicoptero.ObtenerVelocidad())),
                new Opcion("Despegar", () => Console.WriteLine(helicoptero.Despegar())),
                new Opcion("Aterrizar", () => Console.WriteLine(helicoptero.Aterrizar())),
                new Opcion("Apagar", () => Console.WriteLine(helicoptero.Apagar())),
                new Opcion("Regresar a Menú Principal", () => { dentroMenuHelicoptero = false; RegresarPrincipal(); }),
            };

            Menu menuHelicoptero = new Menu("Menú de Helicóptero", opcionesHelicoptero);

            while (dentroMenuHelicoptero)
            {
                menuHelicoptero.MostrarMenu();
                int opcion = menuHelicoptero.SeleccionarOpcion();
                Console.WriteLine();
                opcionesHelicoptero[opcion - 1].Action.Invoke();
                menuHelicoptero.Continuar();
            }
        }

        // Opciones de Salida
        public void Salir()
        {
            Console.WriteLine("Cerrando el programa...");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }

        public void RegresarPrincipal()
        {
            dentroMenuPrincipal = true;
        }
    }
}
