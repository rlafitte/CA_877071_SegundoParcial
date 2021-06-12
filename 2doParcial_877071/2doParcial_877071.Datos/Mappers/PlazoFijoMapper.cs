using _2doParcial_877071.Entidades.Entidades;
using Estudio.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            string json = WebHelper.Get("877071");
            List<PlazoFijo> lista = MapList(json);
            return lista;
        }

        //MapList
        private List<PlazoFijo> MapList(string json)
        {
            List<PlazoFijo> lst = JsonConvert.DeserializeObject<List<PlazoFijo>>(json);
            return lst;

        }


        //Post
        public TransactionResult AltaPlazoFijo (PlazoFijo pf)
        {
            NameValueCollection n = ReverseMap(pf);
            string json = WebHelper.Post("", n);
            TransactionResult res = JsonConvert.DeserializeObject<TransactionResult>(json);
            return res;

        }

        private NameValueCollection ReverseMap(PlazoFijo pf)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", pf.Id.ToString());
            n.Add("usuario", "877071");
            //Tanto id como idCliente se debe enviar en 0
            n.Add("id", "0");
            n.Add("idCliente", "0");
            return n;
        }

        //ReverseMap
    }
}
