﻿using AutoMapper;
using Company.API.Context;
using Company.API.DTOs.AboutDtos;
using Company.API.DTOs.ServiceDtos;
using Company.API.Entities;
using Company.API.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public ServicesController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values = await _context.Services.ToListAsync();
            var mappingValues = _mapper.Map<List<ResultServiceDto>>(values);
            return Ok(mappingValues);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var service = await _context.Services.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }
            var value = _mapper.Map<ResultServiceDto>(service);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateServiceDto model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var value = _mapper.Map<Service>(model);
            await _context.Services.AddAsync(value);
            await _context.SaveChangesAsync();
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateServiceDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var value = _mapper.Map<Service>(model);
            _context.Services.Update(value);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var value = await _context.Services.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }
            _context.Services.Remove(value);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
