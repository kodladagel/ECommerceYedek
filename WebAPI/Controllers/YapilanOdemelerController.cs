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
    public class YapilanOdemelerController : ControllerBase
    {
        IYapilanOdemeService _yapilanOdemeService;

        public YapilanOdemelerController(IYapilanOdemeService yapilanOdemeService)
        {
            _yapilanOdemeService = yapilanOdemeService;
        }

        [HttpGet("getyapilanodemeler")]
        public IActionResult GetAll()
        {
            var result = _yapilanOdemeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getyapilanodemelerbytoptanciid")]
        public IActionResult GetYapilanOdemelerByToptanciId(int toptanciId)
        {
            var result = _yapilanOdemeService.GetAllByToptanciId(toptanciId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getyapilanodemebyyapilanodemeid")]
        public IActionResult GetYapilanOdemeByYapilanOdemeId(int yapilanOdemeId)
        {
            var result = _yapilanOdemeService.GetById(yapilanOdemeId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(YapilanOdeme yapilanOdeme)
        {
            var result = _yapilanOdemeService.Add(yapilanOdeme);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(YapilanOdeme yapilanOdeme)
        {
            var result = _yapilanOdemeService.Update(yapilanOdeme);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(YapilanOdeme yapilanOdeme)
        {
            var result = _yapilanOdemeService.Delete(yapilanOdeme);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
