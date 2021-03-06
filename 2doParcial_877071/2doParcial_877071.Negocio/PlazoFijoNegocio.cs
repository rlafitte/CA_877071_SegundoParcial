using _2doParcial_877071.Datos.Mappers;
using _2doParcial_877071.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcial_877071.Negocio
{
    public class PlazoFijoNegocio
    {
        private PlazoFijoMapper _pfMap;
        private PlazoFijo _pf;
        public PlazoFijoNegocio()
        {
            _pfMap = new PlazoFijoMapper();
            _pf = new PlazoFijo();
        }

        public List<PlazoFijo> CargarPlazosFijos()
        {
            List<PlazoFijo> lst = new List<PlazoFijo>();
            lst = _pfMap.TraerPlazosFijos();
            return lst;
        }

        public void AltaPlazoFijo(PlazoFijo pf)
        {
            _pfMap.AltaPlazoFijo(pf);
        }

        public string CalcularInteres(string cap, string dias, string tasa)
        {
            double d = _pf.InteresCalculado(cap, dias, tasa);
            return d.ToString("0.00");
        }

        public string CalcularMontoFinal(string cap, string dias, string tasa)
        {
            _pf.CapitalInicial = Convert.ToDouble(cap);
            _pf.Dias = Convert.ToInt32(dias);
            _pf.Tasa = Convert.ToDouble(tasa);
            double d = _pf.MontoFinal();
            return d.ToString("0.00");
        }
        public void ValidarMontoMaximo(double d)
        {
            if (d > 1000000)
            {
                throw new Exception("Monto máximo a invertir: $1.000.000");
            }
        }

        public void VerificarEntradas(string text1, string text2)
        {
            double.TryParse(text1, out double d);
            double.TryParse(text2, out double f);
            if (d == 0)
            {
                throw new Exception("valor no numérico.");
            }
            if (f == 0)
            {
                throw new Exception("valor no numérico.");
            }

        }
    }
}
