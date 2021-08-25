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
    public class MusterilerController : ControllerBase
    {
        IMusteriService _musteriService;

        public MusterilerController(IMusteriService musteriService)
        {
            _musteriService = musteriService;
        }

        [HttpGet("getmusteriler")]
        public IActionResult GetAll()
        {
            var result = _musteriService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getmusteribymusteriid")]
        public IActionResult GetMusteriByMusteriId(int musteriId)
        {
            var result = _musteriService.GetById(musteriId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Musteri musteri)
        {
            var result = _musteriService.Add(musteri);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Musteri musteri)
        {
            var result = _musteriService.Update(musteri);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Musteri musteri)
        {
            var result = _musteriService.Delete(musteri);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
