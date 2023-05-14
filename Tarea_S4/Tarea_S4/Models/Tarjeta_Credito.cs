using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Tarea_S4.Models
{
    public  class Tarjeta_Credito : Productos_Bancarios
    {

        public double limite_credito { get; set; }  

    }
}
