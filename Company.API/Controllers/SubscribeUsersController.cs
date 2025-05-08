using AutoMapper;
using Company.API.Context;
using Company.API.DTOs.SocialMediaDtos;
using Company.API.DTOs.SubscribeUserDtos;
using Company.API.Entities;
using Company.API.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeUsersController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public SubscribeUsersController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values = await _context.SubscribeUsers.ToListAsync();
            var mappingValues = _mapper.Map<List<ResultSubscribeUserDto>>(values);
            return Ok(mappingValues);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var model = await _context.SubscribeUsers.FindAsync(id);
            if (model == null)
            {
                return NotFound();
            }
            var value = _mapper.Map<ResultSubscribeUserDto>(model);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateSubscribeUserDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var value = _mapper.Map<SubscribeUser>(model);
            await _context.SubscribeUsers.AddAsync(value);
            await _context.SaveChangesAsync();
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateSubscribeUserDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var value = _mapper.Map<SubscribeUser>(model);
            _context.SubscribeUsers.Update(value);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var value = await _context.SubscribeUsers.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }
            _context.SubscribeUsers.Remove(value);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
