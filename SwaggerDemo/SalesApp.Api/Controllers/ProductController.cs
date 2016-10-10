using SalesApp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SalesApp.Api.Controllers
{
    public class ProductController : ApiController
    {
        // GET: api/Product
        public IHttpActionResult Get()
        {
            return Ok(ProductData.Get());
        }

        // GET: api/Product/5
        public IHttpActionResult Get(int id)
        {
            return Ok(ProductData.Get(id));
        }

        // POST: api/Product
        public IHttpActionResult Post(Product model)
        {
            return Ok(ProductData.Add(model));
        }

        // PUT: api/Product/5
        public IHttpActionResult Put([FromUri] int id, Product model)
        {
            model.Id = id;
            return Ok(ProductData.Update(model));
        }

        // DELETE: api/Product/5
        public IHttpActionResult Delete(int id)
        {
            ProductData.Delete(id);
            return Ok();
        }
    }
}
