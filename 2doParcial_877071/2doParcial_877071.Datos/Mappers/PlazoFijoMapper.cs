using _2doParcial_877071.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcial_877071.Datos.Mappers
{
    public class PlazoFijoMapper
    {
        private PlazoFijo _pfDat;
        //Get
        public List<PlazoFijo> TraerPlazosFijos()
        {
            string json = WebHelper.Get("");
            List<PlazoFijo> lista = MapList(json);
            return lista;
        }

        //MapList
        private List<PlazoFijo> MapList(string json)
        {
            
        }


        //Post

        //ReverseMap
    }
}
