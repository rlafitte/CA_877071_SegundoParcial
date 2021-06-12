using _2doParcial_877071.Entidades.Entidades;
using _2doParcial_877071.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2doParcial_877071.GUI
{
    public partial class Form1 : Form
    {
        private PlazoFijoNegocio _plNeg;
        private TipoPlazoFijo _tpf;
        private Operador _op;
        private List<PlazoFijo> _plazos;

        public Form1()
        {
            try
            {

            InitializeComponent();
            _plNeg = new PlazoFijoNegocio();
            _tpf = new TipoPlazoFijo();
                _op = new Operador();
                _plazos = new List<PlazoFijo>();
                CargarTiposPlazosFijo();
            }
            catch
            {

            }
        }

        private void CargarTiposPlazosFijo()
        {
            _tpf.Id = 1;
            _tpf.Desc = "Plazo Fijo Web";
            _tpf.Tasa = 41;
            cbTipoPlazoFijo.Items.Add(_tpf.Id.ToString()); // A REVISAR!!!
             _tpf.Id = 2;
            _tpf.Desc = "Plazo Fijo UVA";
            _tpf.Tasa = 3;
            cbTipoPlazoFijo.Items.Add(_tpf.Id.ToString());
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                
                lstPlazoFijo.DataSource = null;
                lstPlazoFijo.DataSource = _plNeg.CargarPlazosFijos();
                _plazos = _plNeg.CargarPlazosFijos();
                tbMontoTotal.Text = _op.MontoTotal(_plazos).ToString("0.00");
                tbComiTotal.Text = _op.ComisionTotal(_plazos).ToString("0.00");
            }
            catch
            {

            }
        }

        private void btnAtlta_Click(object sender, EventArgs e)
        {
            try
            {
            

            PlazoFijo pf = new PlazoFijo();
                SimularPlazoFijo();
                MapearCamposPlazoFijo(pf);

            _plNeg.AltaPlazoFijo(pf);
                MessageBox.Show("Plazo fijo creado. Monto invertido: " + pf.CapitalInicial);
                lstPlazoFijo.DataSource = _plNeg.CargarPlazosFijos();
                tbMontoTotal.Text = _op.MontoTotal(_plazos).ToString("0.00");
                tbComiTotal.Text = _op.ComisionTotal(_plazos).ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MapearCamposPlazoFijo(PlazoFijo pf)
        {
                pf.Tipo = Convert.ToInt32(cbTipoPlazoFijo.SelectedItem.ToString());
                pf.Tasa = Convert.ToDouble(tbTasaInt.Text);
                pf.CapitalInicial = Convert.ToDouble(tbCapAInvert.Text);
                pf.Dias = Convert.ToInt32(tbDias.Text);

        }

        private void cbTipoPlazoFijo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            //TipoPlazoFijo tpf = (TipoPlazoFijo)cbTipoPlazoFijo.SelectedItem;

            if (cbTipoPlazoFijo.SelectedItem != null)
            {

            string s = cbTipoPlazoFijo.SelectedItem.ToString();
            // lógica a corregir hasta resolver el combox
            if (s == "1")
            {
            //tbTasaInt.Text = tpf.Id.ToString();
            tbTasaInt.Text = "41";

            }
            if (s == "2")
            {
            //tbTasaInt.Text = tpf.Id.ToString();
            tbTasaInt.Text = "3";

            }
            }
            
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            try
            {
                SimularPlazoFijo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SimularPlazoFijo()
        {
            _plNeg.VerificarEntradas(tbCapAInvert.Text, tbDias.Text);    
            
            _plNeg.ValidarMontoMaximo(Convert.ToDouble(tbCapAInvert.Text));
                tbIntARecib.Text = _plNeg.CalcularInteres(tbCapAInvert.Text, tbDias.Text, tbTasaInt.Text);
                tbMontoFinal.Text = _plNeg.CalcularMontoFinal(tbCapAInvert.Text, tbDias.Text, tbTasaInt.Text);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            cbTipoPlazoFijo.SelectedIndex = -1;
            tbTasaInt.Clear();
            tbCapAInvert.Clear();
            tbDias.Clear();
            tbIntARecib.Clear();
            tbMontoFinal.Clear();

        }
    }
}
