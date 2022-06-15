using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consecionaria__Honda
{
    class Venta_Seguros
    {
        String dni;
        String nombre;
        String placa;
        String modelo;
        String aFabr;
        String aVen;
        String poliza;

        public Venta_Seguros(String dni, String nombre, String placa, String modelo, String aFabr, String aVen, String poliza)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.placa = placa;
            this.modelo = modelo;
            this.aFabr = aFabr;
            this.aVen = aVen;
            this.poliza = poliza;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string AFabr { get => aFabr; set => aFabr = value; }
        public string AVen { get => aVen; set => aVen = value; }
        public string Poliza { get => poliza; set => poliza = value; }

    }
}
