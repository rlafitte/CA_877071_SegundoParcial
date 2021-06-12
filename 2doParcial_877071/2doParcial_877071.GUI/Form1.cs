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

        public Form1()
        {
            try
            {

            InitializeComponent();
            _plNeg = new PlazoFijoNegocio();
            _tpf = new TipoPlazoFijo();
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
            _plNeg.AltaPlazoFijo(pf);
            }
            catch
            {

            }
        }

        private void cbTipoPlazoFijo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            TipoPlazoFijo tpf = (TipoPlazoFijo)cbTipoPlazoFijo.SelectedItem;
            tbTasaInt.Text = tpf.Id.ToString();
        }
    }
}
