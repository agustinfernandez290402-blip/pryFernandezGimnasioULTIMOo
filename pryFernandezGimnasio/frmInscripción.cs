namespace pryFernandezGimnasio
{
    public partial class frmInscripción : Form
    {
        string[] arrayClientes = new string[5];
        int indiceClientes = 0;

        const decimal PRECIO_MUSCULACION = 15000.00m;
        const decimal PRECIO_FUNCIONAL = 18000.00m;
        const decimal PRECIO_NATACION = 22000.00m;
        const decimal PRECIO_CASILLERO = 3000.00m;
        const int EDAD_MINIMA = 14;
        const decimal RECARGO_TARJETA = 0.20m; // 20% de recargo
        public frmInscripción()
        {
            InitializeComponent();
        }
        private void EstadoInicial()
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtMeses.Text = "1";
            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;
            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;
            rbtEfectivo.Checked = true;
            cboCuotas.SelectedIndex = -1;
            cboCuotas.Enabled = false;
            btnCalcular.Enabled = false;
            txtNombre.Focus();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            {
                EstadoInicial();
            }
        }

        private void frmInscripción_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombreIngresado = txtNombre.Text;
            string apellidoIngresado = txtApellido.Text;
            int edadIngresada = 0;
            int cantidadMeses = 0;

            decimal precioMensual = 0.00m;
            decimal subtotal = 0.00m;
            decimal porcentajeDescuento = 0.00m;
            decimal porcentajeAjustePago = 0.00m;

            decimal valorCuota = 0.00m;

            edadIngresada = int.Parse(txtEdad.Text);
            cantidadMeses = int.Parse(txtMeses.Text);
            if (edadIngresada < EDAD_MINIMA)
            {
                MessageBox.Show("La edad ingresada no alcanza el mínimo requerido de 14 años.");
                return;
            }
            if (cantidadMeses < 1 || cantidadMeses > 12)
            {
                MessageBox.Show("La cantidad de meses debe estar comprendida entre 1 y 12.");
                return;
            }

            string planElegido = cboPlan.Text;

            switch (planElegido)
            {
                case "Musculación":
                    precioMensual = PRECIO_MUSCULACION;
                    break;
                case "Funcional":
                    precioMensual = PRECIO_FUNCIONAL;
                    break;
                case "Natación":
                    precioMensual = PRECIO_NATACION;
                    break;
                default:
                    MessageBox.Show("Por favor, seleccione un plan válido.");
                    return;
            }
            int indiceTurno = cboTurno.SelectedIndex;
            string horarioTurno = "";

            switch (indiceTurno)
            {
                case 0:
                    horarioTurno = "Mañana (7 a 12 h)";
                    break;
                case 1:
                    horarioTurno = "Tarde (14 a 18 h)";
                    break;
                case 2:
                    horarioTurno = "Noche (18 a 23 h)";
                    break;
                default:
                    horarioTurno = "Turno a definir";
                    break;
            }

            if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;


            subtotal = precioMensual * cantidadMeses;

            porcentajeDescuento = 0.00m;


            if (edadIngresada < 18)
            {
                porcentajeDescuento = 0.25m;
            }
            else
            {
                if (edadIngresada >= 65)
                {
                    porcentajeDescuento = 0.30m;
                }
                else
                {
                    if (chkEstudiante.Checked)
                    {
                        porcentajeDescuento = 0.15m;
                    }
                    else
                    {
                        porcentajeDescuento = 0.00m;
                    }
                }
            }


            decimal montoDescuento = subtotal * porcentajeDescuento;
            decimal subtotalConDescuento = subtotal - montoDescuento;
            porcentajeAjustePago = 0.00m;


            if (rbtEfectivo.Checked)
            {
                porcentajeAjustePago = -0.10m;
            }
            else
            {

                int cuotasElegidas = int.Parse(cboCuotas.Text);

                if (cuotasElegidas == 1)
                {
                    porcentajeAjustePago = 0.00m;
                }
                else if (cuotasElegidas == 3)
                {
                    porcentajeAjustePago = 0.10m;
                }
                else if (cuotasElegidas == 6)
                {
                    porcentajeAjustePago = 0.20m;
                }
            }


            decimal montoDescuentoEdad = subtotal * porcentajeDescuento;
            subtotalConDescuento = subtotal - montoDescuentoEdad;

            decimal montoAjustePago = subtotalConDescuento * porcentajeAjustePago;
            decimal totalFinal = subtotalConDescuento + montoAjustePago;

            string categoriaSocio = (edadIngresada < 18) ? "Menor" : "Mayor";
            string textoFormaPago = rbtEfectivo.Checked ? "Efectivo" : "Tarjeta en " + cboCuotas.Text + " cuotas";
            int cantidadCuotasValor = rbtEfectivo.Checked ? 1 : int.Parse(cboCuotas.Text);
            valorCuota = totalFinal / cantidadCuotasValor;
            string textoDescuentoEdad = (porcentajeDescuento == 0.25m) ? "25% (Menor de 18)" :
                                (porcentajeDescuento == 0.30m) ? "30% (65 años o más)" :
                                (porcentajeDescuento == 0.15m) ? "15% (Estudiante)" : "Sin descuento";
            string textoAjustePago = (porcentajeAjustePago == -0.10m) ? "10% de Descuento (Efectivo)" :
                             (porcentajeAjustePago == 0.00m) ? "Sin recargo (1 cuota)" :
                             (porcentajeAjustePago == 0.10m) ? "10% de Recargo (3 cuotas)" : "20% de Recargo (6 cuotas)";

            string mensaje = "--- RESUMEN DE INSCRIPCIÓN ---\n" +
                 "Socio: " + nombreIngresado + " " + apellidoIngresado + " (" + categoriaSocio + ")\n" +
                 "Edad: " + edadIngresada + " años\n" +
                 "Plan: " + planElegido + "\n" +
                 "Turno: " + horarioTurno + "\n" +
                 "Meses: " + cantidadMeses + "\n" +
                 "Descuento Aplicado: " + textoDescuentoEdad + "\n" +
                 "Forma de Pago: " + textoFormaPago + " (" + textoAjustePago + ")\n" +
                 "Total a Pagar: $" + totalFinal.ToString("N2", new System.Globalization.CultureInfo("es-AR"));


            MessageBox.Show(mensaje, "Gimnasio Siglo - Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);


            string mensajeParaVector = nombreIngresado + " " + apellidoIngresado + " | Plan: " + planElegido + " | Turno: " + horarioTurno + " | Meses: " + cantidadMeses + " | Total: $" + totalFinal.ToString("N2", new System.Globalization.CultureInfo("es-AR"));

            if (indiceClientes < arrayClientes.Length)
            {
                arrayClientes[indiceClientes] = mensajeParaVector;
                indiceClientes++;
            }

            if (indiceClientes == arrayClientes.Length)
            {
                btnCalcular.Enabled = false;
            }

            EstadoInicial();
            {
                txtNombre.Clear();
                txtApellido.Clear();
                txtEdad.Clear();
                txtMeses.Clear();
                chkEstudiante.Checked = false;
                chkCasillero.Checked = false;
                cboPlan.SelectedIndex = -1;
                cboTurno.SelectedIndex = -1;
                cboCuotas.SelectedIndex = -1;
                cboCuotas.Enabled = false;
                rbtEfectivo.Checked = true;
                rbtTarjeta.Checked = false;
                txtNombre.Focus();
            }
        }


        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {

                e.Handled = true;
            }
        }

        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {

                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && txtEdad.Text != "" && txtMeses.Text != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;

            }

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTarjeta.Checked)
            {
                cboCuotas.Enabled = true;
                cboCuotas.SelectedIndex = 0; 
            }
            else
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = -1; 
            }




        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Clientes.Items.Clear(); 

            for (int i = 0; i < indiceClientes; i++)
            {
                Clientes.Items.Add(arrayClientes[i]);
                Clientes.HorizontalExtent = 700;
            }
            
        }
    }
    }

