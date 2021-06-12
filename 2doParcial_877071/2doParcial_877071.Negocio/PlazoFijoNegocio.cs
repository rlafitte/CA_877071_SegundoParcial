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
    }
}
