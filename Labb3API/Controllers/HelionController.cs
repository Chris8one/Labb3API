using Labb3API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelionController : ControllerBase
    {
        private IHelion _helion;

        public HelionController(IHelion helion)
        {
            _helion = helion;
        }

        [HttpGet("persons/{id:int}")]
        public IActionResult GetAPerson(int id)
        {
            try
            {
                var result = _helion.GetPerson(id);

                if (result == null)
                {
                    return NotFound($"The person with id {id} wasn't found..");
                }

                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrieve data from the database..");
            }
        }

        [HttpGet("persons")]
        public IActionResult GetAllPersons()
        {
            try
            {
                return Ok(_helion.GetPersons());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrieve data from the database..");
            }
        }

        [HttpGet("interests/{id:int}")]
        public async Task<ActionResult> GetPersonInterests(int id)
        {
            try
            {
                var result = await _helion.GetInterests(id);

                if (result == null)
                {
                    return NotFound($"The person with id {id} wasn't found..");
                }

                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrieve data from the database..");
            }
        }

        [HttpGet("links/{id:int}")]
        public async Task<ActionResult> GetPersonLinks(int id)
        {
            try
            {
                var result = await _helion.GetLinks(id);

                if (result == null)
                {
                    return NotFound($"The person with id {id} wasn't found..");
                }

                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrieve data from the database..");
            }
        }

        [HttpPost("newinterest/{id:int}")]
        public IActionResult NewHobby(int id, Interest interest)
        {
            try
            {
                var addNewInterest = _helion.GetPerson(id);

                if (addNewInterest != null)
                {
                    _helion.AddInterest(interest);
                    _helion.personInterest(new PersonInterest()
                    {
                        InterestId = interest.InterestId,
                        PersonId = addNewInterest.PersonId
                    }) ;
                }

                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPost("newlink/personid/{personid:int}/interestid/{interestid:int}")]
        public IActionResult NewLink(int interestid, int personid, Link link)
        {
            try
            {
                var AddLinkToPerson = _helion.GetPerson(personid);
                var addLinkToInterest = _helion.GetInterest(interestid);

                if (AddLinkToPerson != null && addLinkToInterest != null)
                {
                    link.PersonId = personid;
                    link.InterestId = interestid;

                    _helion.AddLink(link);
                }

                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPost("persons")]
        public IActionResult NewPerson(Person newPerson)
        {
            try
            {
                if (newPerson == null)
                {
                    return BadRequest();
                }

                var createdPerson = _helion.AddPerson(newPerson);

                return Ok();
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to add a new person to the database..");
            }
        }

        [HttpGet("persons/{name}")]
        public IActionResult SearchPersons(string name)
        {
            try
            {
                var searchResult = _helion.Search(name);

                if (searchResult.Any())
                {
                    return Ok(searchResult);
                }

                return NotFound();
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Something went wrong..");
            }
        }
    }
}
