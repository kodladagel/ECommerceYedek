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
    public class AlinanOdemelerController : ControllerBase
    {
        IAlinanOdemeService _alinanOdemeService;

        public AlinanOdemelerController(IAlinanOdemeService alinanOdemeService)
        {
            _alinanOdemeService = alinanOdemeService;
        }

        [HttpGet("getalinanodemeler")]
        public IActionResult GetAll()
        {
            var result = _alinanOdemeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getalinanodemelerbymusteriid")]
        public IActionResult GetAlinanOdemelerByMusteriId(int musteriId)
        {
            var result = _alinanOdemeService.GetAllByMusteriId(musteriId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getalinanodemebyalinanodemeid")]
        public IActionResult GetAlinanOdemeByAlinanOdemeId(int alinanOdemeId)
        {
            var result = _alinanOdemeService.GetById(alinanOdemeId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(AlinanOdeme alinanOdeme)
        {
            var result = _alinanOdemeService.Add(alinanOdeme);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(AlinanOdeme alinanOdeme)
        {
            var result = _alinanOdemeService.Update(alinanOdeme);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(AlinanOdeme alinanOdeme)
        {
            var result = _alinanOdemeService.Delete(alinanOdeme);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
