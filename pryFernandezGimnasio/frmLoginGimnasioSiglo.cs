using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryFernandezGimnasio
{
    public partial class frmLoginGimnasioSiglo : Form
    {
        public frmLoginGimnasioSiglo()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmInscripción ventanaInscripcion = new frmInscripción();
            ventanaInscripcion.Show(); // Abre tu ventana principal del gimnasio
            this.Hide(); // Oculta esta pantalla de login
        }
    }
    }

