using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaBox.Storing.Repositories;
using PizzaBox.Domain.Models;
using Microsoft.AspNetCore.Http;
using System.Net.Mime;


namespace PizzaBoxService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaOrderController : ControllerBase
    {
        private readonly IRepository<PizzaOrder> repo;
        public PizzaOrderController(IRepository<PizzaOrder> repo)
        {
            this.repo = repo;
        }
       
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<PizzaOrder> Get()
        {
            try
            {
                return Ok(repo.GetList());
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<PizzaOrder> Get([FromRoute] int id)
        {
            try
            {
                return Ok(repo.GetById(id));
            }
            catch
            {
                return NotFound($"PizzaOrder {id} does not exist.");
            }
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Consumes(MediaTypeNames.Application.Json)]
        public IActionResult Post([FromBody] PizzaOrder x) 
        {
            if (x == null)
            {
                return BadRequest("The PizzaOrder you are trying to add is empty");
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    repo.Add(x);
                    return CreatedAtAction(nameof(Get), new { id = x.OrderId }, x);
                }
            }
        }
        //[HttpDelete("{id}")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public ActionResult Delete(int id)
        //{
        //    try
        //    {
        //        repo.Remove(id);
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(400, ex.Message);
        //    }
        //}
        //[HttpPut]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public ActionResult<PizzaOrder> Put(PizzaOrder x)
        //{
        //    try
        //    {
        //        repo.Update(x);
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(400, ex.Message);
        //    }
        //}

    }
}
