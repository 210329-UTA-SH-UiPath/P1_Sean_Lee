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
    public class CustController : ControllerBase
    {
        private readonly CustRepo repo;
        public CustController(CustRepo repo)
        {
            this.repo = repo;
        }
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Cust> Get()
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
        public ActionResult<Cust> Get([FromRoute] int id)
        {
            try
            {
                return Ok(repo.GetById(id));
            }
            catch (Exception ex)
            {
                return NotFound($"Customer: {id} does not exist.");
            }
        }
        [HttpGet("{name}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Cust> Get([FromRoute] string name)
        {
            try
            {
                return Ok(repo.GetByName(name));
            }
            catch (Exception ex)
            {
                return NotFound($"Customer: {name} does not exist.");
            }
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        
        [Consumes(MediaTypeNames.Application.Json)]
        public IActionResult Post([FromBody] Cust x)         {
            if (x == null)
            {
                return BadRequest("The customer you are trying to add is empty");
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
                    return CreatedAtAction(nameof(Get), new { id = x.Id }, x);
                }
            }
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Cust> Delete(int id)
        {
            try
            {
                repo.Remove(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Put(Cust x)
        {
            try 
            {
                repo.Update(x);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(401, ex.Message);
            }
        }

    }
}
