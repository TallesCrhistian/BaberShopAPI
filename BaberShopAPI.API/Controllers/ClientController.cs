using AutoMapper;
using BaberShopAPI.Application.Interfaces;
using BaberShopAPI.Shared.Dtos;
using BaberShopAPI.Shared.DTOs;
using BaberShopAPI.Shared.ViewModels.Client;
using Microsoft.AspNetCore.Mvc;

namespace BaberShopAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IClientServices _iClientServices;
        private IMapper _mapper;

        public ClientController(IClientServices clienteServicos, IMapper mapper)
        {
            _iClientServices = clienteServicos;
            _mapper = mapper;
        }

        [HttpPost]
        [Route(nameof(Inserir))]
        public async Task<IActionResult> Inserir([FromBody] InsertClientViewModel clientViewModel)
        {
            ClientDTO clientDTO = _mapper.Map<ClientDTO>(clientViewModel);

            SeviceResponseDTO<ClientDTO> seviceResponseDTO = await _iClientServices.Inserir(clientDTO);

            return Ok(seviceResponseDTO);
        }
    }
}
