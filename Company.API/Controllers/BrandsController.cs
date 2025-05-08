using AutoMapper;
using Company.API.Context;
using Company.API.DTOs.BannerDtos;
using Company.API.DTOs.BrandDtos;
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
    public class BrandsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public BrandsController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values = await _context.Brands.ToListAsync();
            var mappingValues = _mapper.Map<List<ResultBrandDto>>(values);
            return Ok(mappingValues);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var brand = await _context.Brands.FindAsync(id);
            if (brand == null)
            {
                return NotFound();
            }
            var mappingBrand = _mapper.Map<ResultBrandDto>(brand);
            return Ok(mappingBrand);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBrandDto model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var brand = _mapper.Map<Brand>(model);
            await _context.Brands.AddAsync(brand);
            await _context.SaveChangesAsync();
            return Ok(brand);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateBrandDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var mappingBrand = _mapper.Map<Brand>(model);
            _context.Brands.Update(mappingBrand);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var brand = await _context.Brands.FindAsync(id);
            if (brand == null)
            {
                return NotFound();
            }
            _context.Brands.Remove(brand);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
