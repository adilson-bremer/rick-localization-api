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
    [Route("api/dimensoes")]
    public class DimensoesController : ControllerBase {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DimensoesController(IUnitOfWork unitOfWork, IMapper mapper) {

            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dimensao>>> Get() {

            IEnumerable<Dimensao> dimensoes = await _unitOfWork.DimensaoRepository.GetAll();

            return Ok(_mapper.Map<IEnumerable<DimensaoDto>>(dimensoes));
        }
    }
}
