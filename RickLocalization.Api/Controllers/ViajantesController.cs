using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> Index() {

            IEnumerable<Viajante> viajantes = await _unitOfWork.ViajanteRepository.GetAllAsync();

            return Ok(viajantes);
        }
    }
}
