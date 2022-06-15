using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consecionaria__Honda
{
    class Servicio_Taller
    {
        String nomAsesor;
        double codigoTaller;
        String diagnostico;
        String nomCliente;
        String monto;
        String modelo;
        String color;
        String placa;

        public Servicio_Taller(String nomAsesor, double codigoTaller, String diagnostico, String nomCliente,
            String monto, String modelo, String color, String placa)
        {
            this.nomAsesor = nomAsesor;
            this.codigoTaller = codigoTaller;
            this.diagnostico = diagnostico;
            this.nomCliente = nomCliente;
            this.monto = monto;
            this.modelo = modelo;
            this.color = color;
            this.placa = placa;

        }
        public string NomAsesor { get => nomAsesor; set => nomAsesor = value; }
        public double CodigoTaller { get => codigoTaller; set => codigoTaller = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string NomCliente { get => nomCliente; set => nomCliente = value; }
        public string Monto{ get => monto; set => monto = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color{ get => color; set => color = value; }
        public string Placa { get => placa; set => placa = value; }

    }
}
