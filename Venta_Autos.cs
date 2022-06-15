using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consecionaria__Honda
{
    class Venta_Autos
    {
        String dni;
        String codigo;
        String matricula;
        string modelo;
        int npuertas;
        String color;
        double precio;


        public Venta_Autos(String dni, String codigo, String matricula, String modelo, int npuertas, String color, double precio)
        {
            this.dni = dni;
            this.codigo = codigo;
            this.matricula = matricula;
            this.modelo = modelo;
            this.npuertas = npuertas;
            this.color = color;
            this.precio = precio;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Npuertas { get => npuertas; set => npuertas = value; }
        public string Color { get => color; set => color = value; }
        public double Precio { get => precio; set => precio = value; }

        public double getPrecio() { return precio; }

    }
}
