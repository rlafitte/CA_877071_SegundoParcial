using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcial_877071.Entidades.Entidades
{
    public class PlazoFijo
    {
        private int _id;
        private int _idCliente;
        private int _tipo;
        private double _tasa;
        private int _dias;
        private double _capitalInicial;
        private string _usuario;
        private double _inte;


        public int Id { get => _id; set => _id = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int Tipo { get => _tipo; set => _tipo = value; }
        public double Tasa { get => _tasa; set => _tasa = value; }
        public int Dias { get => _dias; set => _dias = value; }
        public double CapitalInicial { get => _capitalInicial; set => _capitalInicial = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public double Inte { get => _inte; set => _inte = value; }

        public PlazoFijo(int id, int idCliente, int tipo, double tasa, int dias, double capitalInicial, string usuario)
        {
            Id = id;
            IdCliente = idCliente;
            Tipo = tipo;
            Tasa = tasa;
            Dias = dias;
            CapitalInicial = capitalInicial;
            Usuario = usuario;
            //Interes = interes;
            //MontoFinal = montoFinal;
        }
        public PlazoFijo()
        {

        }

        public override string ToString()
        {
            return $"ID: {this.Id} - Capital inicial: {this.CapitalInicial}";
        }

        public double InteresCalculado(string cap, string dias, string tasa)
        {
            double d = Convert.ToDouble(cap);
            int i = Convert.ToInt32(dias);
            double t = Convert.ToDouble(tasa);
            //((tasa / 365 * dias) * CapitalInicial) / 100)
            this.Inte = t;
            return (t / (365 * i) * d / 100);
        }

        public double MontoFinal()
        {

            double d4 =    this.InteresCalculado(this.CapitalInicial.ToString(), this.Dias.ToString(), this.Tasa.ToString());
            return (this.CapitalInicial + d4);
        }
    }
}
