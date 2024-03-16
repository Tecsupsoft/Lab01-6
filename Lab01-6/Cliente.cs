using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_6
{
    public class Cliente : Usuario
    {
       

        public double LitrosCargados { get; set; }

      

        public Cliente (string nombre, double saldo, double pLitrosCargados) : base(nombre, saldo)
        {
            LitrosCargados = pLitrosCargados;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine(LitrosCargados);
        }

    }
}
