using IntegraBasil.Application.Integration.Interfaces;
using IntegraBasil.Application.Integration.Services;
using IntegraBasil.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace IntegraBasil.Api.Controller
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBankIntegrationService _bankIntegrationService;

        public BankController(IBankIntegrationService bankIntegrationService)
        {
            _bankIntegrationService = bankIntegrationService;
        }

        [HttpGet("banks")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetBansAlls()
        {
            var response = await _bankIntegrationService.GetAllBanks();

            if (response.CodeHttp == HttpStatusCode.OK)
            {
                return Ok(response.DatasReturn);
            }
            else
            {
                return StatusCode((int)response.CodeHttp, response.ErrorReturn);
            }
        }

        [HttpGet("busca/{codeBank}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetByBank([RegularExpression("^[0-9]*$")] string codeBank)
        {
            var response = await _bankIntegrationService.GetBankById(codeBank);

            if (response.CodeHttp == HttpStatusCode.OK)
            {
                return Ok(response.DatasReturn);
            }
            else
            {
                return StatusCode((int)response.CodeHttp, response.ErrorReturn);
            }
        }

    }
}
