
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using GdMAPI.Data;
using GdMAPI.Models;
using GdMAPI.Models.Enum;

namespace GdMAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class MaterialController : ControllerBase
    {
        private readonly DataContext _context;

        public MaterialController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Add(Material novoMaterial)
        {
            try
            {
                Material materialExistente = await _context.TB_MATERIAL.FirstOrDefaultAsync(m =>
                    m.Id != novoMaterial.Id &&
                    m.Nome == novoMaterial.Nome &&
                    m.Cor == novoMaterial.Cor &&
                    m.Marca == novoMaterial.Marca &&
                    m.Tipo == novoMaterial.Tipo);

                if (materialExistente != null)
                {
                    throw new Exception("O material já existe, tente apenas altera-lo");
                }
                else
                {
                    await _context.TB_MATERIAL.AddAsync(novoMaterial);
                    await _context.SaveChangesAsync();
                    return Ok(novoMaterial.Id);
                }
            }
            catch (SystemException e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Material m = await _context.TB_MATERIAL.FirstOrDefaultAsync(mBusca => mBusca.Id == id);
                return Ok(m);
            }
            catch (SystemException e)
            {
                return BadRequest(e);
            }
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Material> lista = await _context.TB_MATERIAL.ToListAsync();
                return Ok(lista);
            }
            catch (SystemException e)
            {
                return BadRequest(e);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update(Material novoMaterial)
        {
            try
            {
                Material materialExistente = await _context.TB_MATERIAL.FirstOrDefaultAsync(m =>
                    m.Id != novoMaterial.Id &&
                    m.Nome == novoMaterial.Nome &&
                    m.Cor == novoMaterial.Cor &&
                    m.Marca == novoMaterial.Marca &&
                    m.Tipo == novoMaterial.Tipo);

                if (materialExistente != null)
                {
                    throw new Exception("O material já existe.");
                }
                else
                {
                    _context.TB_MATERIAL.Update(novoMaterial);
                    int linhasAfetadas = await _context.SaveChangesAsync();
                    return Ok(linhasAfetadas);
                }
            }
            catch (SystemException e)
            {
                return BadRequest(e);
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Material mRemover = await _context.TB_MATERIAL.FirstOrDefaultAsync(m => m.Id == id);

                _context.TB_MATERIAL.Remove(mRemover);
                int linhasafetadas = await _context.SaveChangesAsync();
                return Ok(linhasafetadas);
            }
            catch (SystemException e)
            {
                return BadRequest(e);
            }
        }



    }
}