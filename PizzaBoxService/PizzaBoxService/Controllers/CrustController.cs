using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaBox.Storing.Repositories;
using PizzaBox.Domain.Models;
using Microsoft.AspNetCore.Http;
using System.Net.Mime;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzaBoxService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrustController : ControllerBase
    {
        private readonly IRepository<Crust> repo;
        public CrustController(IRepository<Crust> repo)
        {
            this.repo = repo;
        }
        // GET: api/<CrustController>
        [HttpGet]//"api/SuperHeroDb/1"
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Crust> Get()
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
        [HttpGet("{id:int}")]//"api/PizzaBoxDb/1"
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Crust> Get([FromRoute] int id)
        {
            try
            {
                return Ok(repo.GetById(id));
            }
            catch (Exception ex)
            {
                return NotFound($"Crust {id} does not exist.");
            }
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[Consumes("application/json")]
        [Consumes(MediaTypeNames.Application.Json)]
        public IActionResult Post([FromBody] Crust x) //model binder of asp.net core will look for this parameter from request body
        {
            if (x == null)
            {
                return BadRequest("The Crust you are trying to add is empty");
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
                    //actionName, routeValues, value
                    return CreatedAtAction(nameof(Get), new { id = x.Id }, x);
                }
            }
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Delete(int id)
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
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Crust> Put(Crust x)
        {
            try
            {
                repo.Update(x);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }

    }
}
