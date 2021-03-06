﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using clip_money.Models;

namespace clip_money.Controllers
{
    [Authorize]
    [RoutePrefix("api/CuentaVirtual")]
    public class CuentaVirtualController : ApiController
    {
        // GET: api/CuentaVirtual
        public IEnumerable<CuentaVirtual> Get()
        {
            GestorCuentaVirtual gCuentaVirtual = new GestorCuentaVirtual();
            return gCuentaVirtual.obtenerCuentasVirtuales();
        }

        // GET: api/CuentaVirtual/"número de id"
        public CuentaVirtual Get(int id)
        {
            GestorCuentaVirtual gCuentaVirtual = new GestorCuentaVirtual();
            return gCuentaVirtual.obtenerPorId(id);
        }

        // POST: api/CuentaVirtual
        public void Post([FromBody] CuentaVirtual nueva)
        {
            GestorCuentaVirtual gCuentaVirtual = new GestorCuentaVirtual();
            //return gCuentaVirtual.nuevaCuentaVirtual(nueva);

        }

        // PUT: api/CuentaVirtual/"número de id"
        public void Put(int id, [FromBody] CuentaVirtual mod)
        {
            GestorCuentaVirtual gCuentaVirtual = new GestorCuentaVirtual();
            //return gCuentaVirtual.modificarCuentaVirtual(id);

        }

        // DELETE: api/CuentaVirtual/"número de id"
        public void Delete(int id)
        {
            GestorCuentaVirtual gCuentaVirtual = new GestorCuentaVirtual();
            //return gCuentaVirtual.eliminarCuentaVirtual(id);

        }
    }
}
