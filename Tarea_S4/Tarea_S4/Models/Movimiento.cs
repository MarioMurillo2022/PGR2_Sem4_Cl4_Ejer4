using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_S4.Models
{
    public class Movimiento
    {

        public string nom_movimiento { get; set; }
        public DateTime fecha_movimiento { get; set; }
        public double valor_movimiento { get; set; }

        public Movimiento(string nm, double vm, DateTime fm)
        {

            nom_movimiento = nm;
            valor_movimiento = vm;
            fecha_movimiento = fm;

        } 

        public override string ToString()
        {
            return $" Nombre de movimiento: {nom_movimiento}: Fecha de movimiento: {fecha_movimiento}: Valor de movimiento: {valor_movimiento} ";
        
        }

    }
}
