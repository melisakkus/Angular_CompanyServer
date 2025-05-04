using AutoMapper;
using Company.API.Context;
using Company.API.DTOs.ServiceDtos;
using Company.API.DTOs.SocialMediaDtos;
using Company.API.Entities;
using Company.API.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        SocialMediaValidator validator = new SocialMediaValidator();

        public SocialMediasController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values = await _context.SocialMedias.ToListAsync();
            var mappingValues = _mapper.Map<List<ResultSocialMediaDto>>(values);
            return Ok(mappingValues);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var model = await _context.SocialMedias.FindAsync(id);
            if (model == null)
            {
                return NotFound();
            }
            var value = _mapper.Map<ResultSocialMediaDto>(model);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateSocialMediaDto model)
        {
            var value = _mapper.Map<SocialMedia>(model);
            var result = await validator.ValidateAsync(value);
            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                    return BadRequest(result.Errors);
                }
            }
            await _context.SocialMedias.AddAsync(value);
            await _context.SaveChangesAsync();
            return Ok(value);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(UpdateSocialMediaDto model)
        {
            var value = _mapper.Map<SocialMedia>(model);
            var result = await validator.ValidateAsync(value);
            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                    return BadRequest(result.Errors);
                }
            }
            _context.SocialMedias.Update(value);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var value = await _context.SocialMedias.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }
            _context.SocialMedias.Remove(value);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
