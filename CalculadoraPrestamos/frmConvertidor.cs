using CalculadoraPrestamos.CustomComboBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaPrestamo;

namespace CalculadoraPrestamos
{
    public partial class frmConvertidor : Form
    {
        Service servicio;
        ComboBoxItem SelectedTasaAnual;
        ComboBoxItem SelectedTipoPrestamo;
        ComboBoxItem SelectedPagoMensuales;
        TxTItem SelectedTexto;
        

        public frmConvertidor()
        {
            InitializeComponent();
        }

        private void frmConvertidor_Load(object sender, EventArgs e)
        {
            loadComboBox();
        }
        private void BTMCalcular_Click(object sender, EventArgs e)
        {
            Validation();
        }
        private void CBXTipoPrestamo_SelectedValueChanged(object sender, EventArgs e)
        {
            TasaAnual();
        }


        private void TasaAnual()
        {
            SelectedTipoPrestamo = CBXTipoPrestamo.SelectedItem as ComboBoxItem;

            SelectedTexto = new TxTItem();

            if (SelectedTipoPrestamo.Value == null)
            {
                TXTTasaAnual.Text = "Seleccione un tipo de prestamo.";
            }
            else
            {
                switch (SelectedTipoPrestamo.Value)
                {
                    case (int)TiposIntereses.Personal:
                        {
                            SelectedTexto.Texto = "22%";
                            SelectedTexto.Value = 22;

                            TXTTasaAnual.Text = SelectedTexto.Texto;

                            break;
                        }
                    case (int)TiposIntereses.Automovil:
                        {
                            SelectedTexto.Texto = "12%";
                            SelectedTexto.Value = 12;

                            TXTTasaAnual.Text = SelectedTexto.Texto;

                            break;
                        }
                    case (int)TiposIntereses.Hipotecario:
                        {
                            SelectedTexto.Texto = "8%";
                            SelectedTexto.Value = 8;

                            TXTTasaAnual.Text = SelectedTexto.Texto;

                            break;
                        }

                }

            }
        }
        private void Validation()
        {

            try
            {
                SelectedTasaAnual = CBXTipoPrestamo.SelectedItem as ComboBoxItem;
                SelectedPagoMensuales = CBXCuotasMensuales.SelectedItem as ComboBoxItem;
                

                if (SelectedTasaAnual.Value == null)
                {
                    MessageBox.Show("Por favor llene todos los campos para completar su proceso. ", "WARNING TASA");
                }
                else if (string.IsNullOrEmpty(TXTCantPrestamo.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos para completar su proceso.", "WARNING PRESTAMO");
                }
                else if (SelectedPagoMensuales.Value == null)
                {
                    MessageBox.Show("Por favor llene todos los campos para completar su proceso.", "WARNING MESES PAGOS");
                }
                else
                {
                    double Confirmacion = Convert.ToDouble(TXTCantPrestamo.Text);

                    servicio = new Service();
                    TXTCuotaMensual.Text = servicio.CalculoPretamo(Confirmacion,Convert.ToInt32(SelectedPagoMensuales.Value), Convert.ToDouble(SelectedTexto.Value));

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se esperaba un tipo de dato numerico.", "WARNING");

            }
        }
     
        private void loadComboBox()
        {           

            ComboBoxItem DefaultOpc = new ComboBoxItem();
            {
                DefaultOpc.Texto = "Seleccione alguna de nuestras opciones";
                DefaultOpc.Value = null;
            
            }

            ComboBoxItem Personal = new ComboBoxItem();
            {
                Personal.Texto = "Personal";
                Personal.Value = 1;

            }

            ComboBoxItem Automovil = new ComboBoxItem();
            {
                Automovil.Texto = "Automovil";
                Automovil.Value = 2;

            }

            ComboBoxItem Hipotecario = new ComboBoxItem();
            {
                Hipotecario.Texto = "Hipotecario";
                Hipotecario.Value = 3;

            }
           
            CBXTipoPrestamo.Items.Add(DefaultOpc);
            CBXTipoPrestamo.Items.Add(Personal);
            CBXTipoPrestamo.Items.Add(Automovil);
            CBXTipoPrestamo.Items.Add(Hipotecario);
            CBXTipoPrestamo.SelectedItem = DefaultOpc;

            CBXCuotasMensuales.Items.Add(DefaultOpc);

            for (int X = 12; X <= 120; X+= 6)
            {
                ComboBoxItem Meses = new ComboBoxItem();
                {
                    Meses.Texto = $"{X} meses";
                    Meses.Value = X;
                    CBXCuotasMensuales.Items.Add(Meses);
                }
              
            }            
            CBXCuotasMensuales.SelectedItem = DefaultOpc;
        }
    }
}
