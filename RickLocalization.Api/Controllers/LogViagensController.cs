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
    [Route("api/logviagens")]
    public class LogViagensController : ControllerBase {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public LogViagensController(IUnitOfWork unitOfWork, IMapper mapper) {

            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public ActionResult<LogViagemDto> GetLogs(int id) {

            IEnumerable<LogViagemDto> logsViagem = _unitOfWork.LogViagemRepository.GetLogsByViajante(id);

            return Ok(logsViagem);
        }

        [HttpPost]
        public IActionResult Add([FromBody] LogViagemCreateDto logViagemDto) {

            logViagemDto.DataViagem = DateTime.Now;

            try {

                _unitOfWork.LogViagemRepository.Add(_mapper.Map<LogViagem>(logViagemDto));
                _unitOfWork.Save();

                return Ok(new { success = true });

            } catch (Exception e) {
                return BadRequest(new { success = false, error = e.Message });
            }
        }
    }
}
