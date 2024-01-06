using IntegraBasil.Application.Integration.Interfaces;
using IntegraBasil.Application.Integration.Response;
using IntegraBasil.Domain.Entities;
using IntegraBasil.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegraBasil.Api.Controller
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressIntegrationService _addressIntegrationService;

        public AddressController(IAddressIntegrationService addressIntegrationService)
        {
            _addressIntegrationService = addressIntegrationService;
        }

        [HttpGet("busca/{cep}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<AddressVm>> GetByCep([FromRoute] string cep)
        {
            var response = await _addressIntegrationService.GetCep(cep);

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
