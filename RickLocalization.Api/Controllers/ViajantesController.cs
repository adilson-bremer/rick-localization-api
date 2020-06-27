using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RickLocalization.Api.Models;
using RickLocalization.Domain.Entities;
using RickLocalization.Domain.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Api.Controllers {

    [ApiController]
    [Route("api/viajantes")]
    public class ViajantesController : ControllerBase {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ViajantesController(IUnitOfWork unitOfWork, IMapper mapper) {

            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ResponseCache(Duration = 120)]
        public async Task<ActionResult<IEnumerable<ViajanteDto>>> Index() {

            IEnumerable<Viajante> viajantes = await _unitOfWork.ViajanteRepository.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<ViajanteDto>>(viajantes));
        }

        [HttpGet("{id}")]
        public ActionResult<ViajanteDto> GetViajante(int id) {

            Viajante viajante = _unitOfWork.ViajanteRepository.Get(id);
            
            if (viajante == null) {
                return NotFound();
            }

            return Ok(_mapper.Map<ViajanteDto>(viajante));
        }
    }
}
