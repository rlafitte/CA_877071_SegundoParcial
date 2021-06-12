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
        public PlazoFijoNegocio()
        {
            _pfMap = new PlazoFijoMapper();
        }

        public List<PlazoFijo> CargarPlazosFijos()
        {
            List<PlazoFijo> lst = new List<PlazoFijo>();
            lst = _pfMap.TraerPlazosFijos();
            return lst;
        }
    }
}
