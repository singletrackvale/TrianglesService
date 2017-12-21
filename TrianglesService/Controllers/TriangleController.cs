using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TrianglesService.Models;

namespace TrianglesService.Controllers
{
    public class TriangleController : ApiController
    {
        [HttpGet]
        [ResponseType(typeof(Triangle))]
        [Route("api/GetVertices")]
        public IHttpActionResult GetVertices(string row, int column)
        {
            try
            {
                Triangle tri = new Triangle();
                if (tri.GetVertices(row, column))
                    return Ok(tri);
                else
                    throw new Exception();
            }
            catch (Exception ex)
            {
                return BadRequest("Invalid column and/or row. " + ex.Message);
            }
        }

        [HttpGet]
        [ResponseType(typeof(Triangle))]
        [Route("api/GetRowColumn")]
        public IHttpActionResult GetRowColumn(int v1x, int v1y, int v2x, int v2y, int v3x, int v3y)
        {
            try
            {
                Triangle tri = new Triangle();
                if (tri.GetRowColumn(v1x, v1y, v2x, v2y, v3x, v3y))
                    return Ok(tri);
                else
                    throw new Exception();

            }
            catch (Exception ex)
            {
                return BadRequest("Invalid vertices. " + ex.Message);
            }
        }
    }
}
