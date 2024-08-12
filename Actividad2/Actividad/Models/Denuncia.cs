using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Denuncia
    {
        public int Hora { get; set; }
        public int Minuto { get; set; }

        public string Motivo { get; set; }

        public Policia OficialACargo { get; private set; }
        public Persona Denunciante { get; private set; }

        public Denuncia(Policia oficial, Persona denunciante) 
        {
            OficialACargo = oficial;
            Denunciante = denunciante;
        }
    }
}
