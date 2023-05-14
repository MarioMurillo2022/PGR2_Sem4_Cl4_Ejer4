using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_S4.Models
{
    public class Productos_Bancarios
    {

        public double saldo_disponible { get; set; }
        public DateTime fecha_apertura { get; set; }
        public double numero_cuenta { get; set; }
        public double cuenta { get; set; } 
        
        public virtual void cuentaNueva(){}

        public override string ToString()
        {
            return $" Cuenta nueva creada el: {fecha_apertura} numero de cuenta: {numero_cuenta} y su saldo disponible es: {saldo_disponible}"; 
        }

    }
}
