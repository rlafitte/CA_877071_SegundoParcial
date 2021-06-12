using _2doParcial_877071.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcial_877071.Negocio
{
    public class Operador
    {
        private double _comision = 0.15;

        public List<PlazoFijo> ListarPlazosFijos(List<PlazoFijo> lst)
        {
            List<PlazoFijo> _lista = new List<PlazoFijo>();
            return _lista;
        }

        public double MontoTotal(List<PlazoFijo> lst)
        {
            return (lst.Sum(o => o.CapitalInicial));
        }
        public double ComisionTotal(List<PlazoFijo> lst)
        {
            return (lst.Sum(o => o.CapitalInicial) * _comision);
        }
    }
}
