using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Arresto
    {
        public string Motivo { get; set; }
        public Policia OficialACargo { get; private set; }
        public Persona Sujeto { get; private set; }

        public Arresto(Policia oficial, Persona sujeto) 
        {
            OficialACargo= oficial;
            Sujeto = sujeto;
        }
    }
}
