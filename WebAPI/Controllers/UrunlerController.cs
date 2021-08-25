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
    public class UrunlerController : ControllerBase
    {

        IUrunService _urunService;

        public UrunlerController(IUrunService urunService)
        {
            _urunService = urunService;
        }

        [HttpGet("geturunler")]
        public IActionResult GetAll()
        {
            var result = _urunService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("geturunlerbykategoriid")]
        public IActionResult GetUrunlerByKategoriId(int kategoriId)
        {
            var result = _urunService.GetAllByCategoryId(kategoriId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("geturunlerbyperakendefiyati")]
        public IActionResult GetUrunlerByPerakendeFiyati(decimal min, decimal max)
        {
            var result = _urunService.GetAllByUnitPrice(min, max);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("geturunbyurunid")]
        public IActionResult GetUrunByUrunId(int urunId)
        {
            var result = _urunService.GetById(urunId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Urun urun)
        {
            var result = _urunService.Add(urun);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Urun urun)
        {
            var result = _urunService.Update(urun);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Urun urun)
        {
            var result = _urunService.Delete(urun);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
