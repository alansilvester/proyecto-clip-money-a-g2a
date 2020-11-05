﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace clip_money.Models
{
    public class Operaciones
    {
        private int id;
        private string numOperacion;
        private string fecha;
        private string hora;
        private double monto;
        private Estado estado;
        private TipoOperacion tipoOperacion;

        public Operaciones()
        {
        }

        public Operaciones(double monto, TipoOperacion tipoOperacion)
        {
            this.Monto = monto;
            this.TipoOperacion = tipoOperacion;
        }

        public string NumOperacion { get => numOperacion; set => numOperacion = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public double Monto { get => monto; set => monto = value; }
        public int Id { get => id; set => id = value; }
        public TipoOperacion TipoOperacion { get => tipoOperacion; set => tipoOperacion = value; }
        public Estado Estado { get => estado; set => estado = value; }
    }
}