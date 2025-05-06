using AutoMapper;
using Company.API.Context;
using Company.API.DTOs.AboutDtos;
using Company.API.Entities;
using Company.API.Validators;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public AboutsController(AppDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values = await _context.Abouts.ToListAsync();
            var mappingValues = _mapper.Map <List<ResultAboutDto>>(values);
            return Ok(mappingValues);
        }

        [HttpGet("Last")]
        public async Task<IActionResult> GetLastAbout()
        {
            var value = _context.Abouts.OrderByDescending(x=>x.AboutId).FirstOrDefault();
            var mappingValues = _mapper.Map<ResultAboutDto>(value);
            return Ok(mappingValues);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var about = await _context.Abouts.FindAsync(id);
            if (about == null)
            {
                return NotFound();
            }
            var mappingAbout = _mapper.Map<ResultAboutDto>(about);
            return Ok(mappingAbout);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutDto model)
        {
            //var result = await validator.ValidateAsync(about);
            //if (!result.IsValid)
            //{
            //    foreach (var error in result.Errors)
            //    {
            //        ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
            //        return BadRequest(result.Errors);
            //    }
            //}

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var about = _mapper.Map<About>(model);
            _context.Abouts.Add(about);
            await _context.SaveChangesAsync();
            return Ok(about);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateAboutDto aboutDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var mappingAbout = _mapper.Map<About>(aboutDto);
            _context.Abouts.Update(mappingAbout);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var about = await _context.Abouts.FindAsync(id);
            if (about == null)
            {
                return NotFound();
            }
            _context.Abouts.Remove(about);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
