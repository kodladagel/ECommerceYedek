using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarkalarController : ControllerBase
    {
        IMarkaService _markaService;

        public MarkalarController(IMarkaService markaService)
        {
            _markaService = markaService;
        }

        [HttpGet("getmarkalar")]
        public IActionResult GetAll()
        {
            var result = _markaService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getmarkabymarkaid")]
        public IActionResult GetMarkaByMarkaId(int markaId)
        {
            var result = _markaService.GetById(markaId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Marka marka)
        {
            var result = _markaService.Add(marka);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Marka marka)
        {
            var result = _markaService.Update(marka);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Marka marka)
        {
            var result = _markaService.Delete(marka);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
