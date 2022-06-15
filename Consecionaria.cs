using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consecionaria__Honda
{
    class Consecionaria
    {
        

      double usuario;
      double contraseña;
      public Consecionaria(double contraseña, double usuario)
       {
            this.usuario = usuario;
            this.contraseña = contraseña;
       }
        public double Usuario { get => usuario; set => usuario = value; }
        public double Contraseña { get => contraseña; set => contraseña = value; }

    }
    
}
