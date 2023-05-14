using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_S4.Models
{
    public class Cuentas_ahorro : Productos_Bancarios
    {
        public double limite_minimo { get; set; }
        public List<Movimiento> listmovimientos { get; set; } = new List<Movimiento>();

        public string getmovimientos()
        {
            string reporte = ""; 

                foreach (Movimiento  tmp in listmovimientos)
            {
                reporte += tmp.ToString() + "\n";
            }

                return reporte;
        }
    }
}
