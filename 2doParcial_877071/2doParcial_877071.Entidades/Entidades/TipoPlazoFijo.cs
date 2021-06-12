using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcial_877071.Entidades.Entidades
{
    public class TipoPlazoFijo
    {
        private int _id;
        private double _tasa;
        private string _desc;

        public TipoPlazoFijo(int id, double tasa, string desc)
        {
            Id = id;
            Tasa = tasa;
            Desc = desc;
        }
        public TipoPlazoFijo()
        {

        }

        public int Id { get => _id; set => _id = value; }
        public double Tasa { get => _tasa; set => _tasa = value; }
        public string Desc { get => _desc; set => _desc = value; }


        //Datos (son siempre estos, no es necesario consultar a API) por lo tanto no hacemos Get??

        //1, Plazo Fijo Web, 41%
        //2, Plazo Fijo UVA, 3%
    }
}
