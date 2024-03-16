using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_6
{
    public class Usuario
    {
        public string Nombre { get; set; }

        public double Saldo { get; set; }

        public Usuario(string pNombre, double pSaldo)
        {
            Nombre = pNombre;
            Saldo = pSaldo;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine(Saldo + " " + Nombre);
        }

    } 
}

  



