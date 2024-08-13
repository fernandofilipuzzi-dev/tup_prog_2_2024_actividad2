using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        Comisaria destacamento=new Comisaria();

        public FormPrincipal()
        {
            InitializeComponent();
        }
            
        private void btnAltaComisaria_Click(object sender, EventArgs e)
        {
            Policia juan = new Policia(43344232, "Juan Barrientos", 23);//1
            Policia ana = new Policia(40344232, "Ana", 30);//2

            destacamento = new Comisaria();//3 y 4

            destacamento.AsignarPolicia(juan);//5
            destacamento.AsignarPolicia(ana);//6

            #region mostrando los numero de placa de los policias asignados
            comboBox1.Items.Clear();
            comboBox1.Items.Add(juan.NumeroPlaca);
            comboBox1.Items.Add(ana.NumeroPlaca);
            #endregion
        }
        
        private void btnAsignarGuardias_Click(object sender, EventArgs e)
        {
            string nroString=comboBox1.SelectedItem.ToString();

            int nroPlaca=Convert.ToInt32(nroString);
            int nroGuardia = Convert.ToInt32(nupNumeroGuardia.Value);
            int hDesde= Convert.ToInt32(nupHDesde.Value);
            int mDesde=Convert.ToInt32(nupMDesde.Value);
            int duracion=Convert.ToInt32(nupMDuracion.Value);

            Policia agente = destacamento.VerAgente(nroPlaca);

            destacamento.AsignarGuardia(nroGuardia, hDesde, mDesde, duracion, agente);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrarDenuncia_Click(object sender, EventArgs e)
        {
            string nroString = comboBox1.SelectedItem.ToString();
            int nroPlaca = Convert.ToInt32(nroString);
            int hIncidente = Convert.ToInt32(nupHIncidente.Value);
            int mIncidente = Convert.ToInt32(nupMIncidente.Value);
            string motivo = tbMotivo.Text;

            Policia agente = destacamento.VerAgente(nroPlaca);

            int dni = Convert.ToInt32(tbDNI.Text);
            string nombre = tbNombre.Text;
            Persona persona = new Persona(dni, nombre);

            int tipoIncidente = cbxIncidente.SelectedIndex;
            
            destacamento.RegistrarIncidente(agente, persona, motivo, hIncidente, mIncidente, tipoIncidente);
                         
        }

    }
}
