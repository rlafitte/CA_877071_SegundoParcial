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

        public Form1()
        {
            try
            {

            InitializeComponent();
            _plNeg = new PlazoFijoNegocio();
            }
            catch
            {

            }
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
    }
}
