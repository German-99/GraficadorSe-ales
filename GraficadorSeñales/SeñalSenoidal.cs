using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorSeñales
{
    class SeñalSenoidal
    {
        //Auto prperties
        //Atributos encapsulados de c#
        //No tienen rutinas al establecer u obtener valor
        public double Amplitud { get; set; }
        public double Fase { get; set; }
        public double Frecuencia { get; set; }
        
        public List<Muestra> Muestras { get; set; }

        //Constrtuctor se ejecuta al instanciar la clase
        //Sintaxis: public NombreClase(Parametros)

        public SeñalSenoidal()
        {
            Amplitud = 1.0;
            Fase = 0.0;
            Frecuencia = 1.0;

            Muestras = new List<Muestra>();
        }

        public SeñalSenoidal(double amplitud, double fase, double frecuencia)
        {
            Amplitud = amplitud;
            Fase = fase;
            Frecuencia = frecuencia;

            Muestras = new List<Muestra>(); 
        }

        public double evaluar(double tiempo)
        {
            double resultado = 0.0;

            //Evaluar la función
            resultado = Amplitud * Math.Sin((2.0 * Math.PI * Frecuencia * tiempo) + Fase);
            return resultado;
        }

    }
}