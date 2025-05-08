using AutoMapper;
using Company.API.Context;
using Company.API.DTOs.AboutDtos;
using Company.API.DTOs.BannerDtos;
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
    public class BannersController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public BannersController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values = await _context.Banners.ToListAsync();
            var mappingValues = _mapper.Map<List<ResultBannerDto>>(values);
            return Ok(mappingValues);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var banner = await _context.Banners.FindAsync(id);
            if (banner == null)
            {
                return NotFound();
            }
            var mappingBanner = _mapper.Map<ResultBannerDto>(banner);
            return Ok(mappingBanner);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBannerDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var banner = _mapper.Map<Banner>(model);
            await _context.Banners.AddAsync(banner);
            await _context.SaveChangesAsync();
            return Ok(banner);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateBannerDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var mappingBanner = _mapper.Map<Banner>(model);
            _context.Banners.Update(mappingBanner);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var banner = await _context.Banners.FindAsync(id);
            if (banner == null)
            {
                return NotFound();
            }
            _context.Banners.Remove(banner);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
