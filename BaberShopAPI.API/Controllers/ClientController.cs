using AutoMapper;
using BaberShopAPI.Application.Interfaces;
using BaberShopAPI.Data.WorkUnit.Interfaces;
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
        private SeviceResponseDTO<ClientDTO> seviceResponseDTO = new SeviceResponseDTO<ClientDTO>();
        private IClientServices _iClientServices;
        private IMapper _mapper;
        private readonly IWorkUnit _iWorkUnit;

        public ClientController(IClientServices clienteServicos, IMapper mapper, IWorkUnit iWorkUnit)
        {
            _iClientServices = clienteServicos;
            _mapper = mapper;
            _iWorkUnit = iWorkUnit;
        }

        [HttpPost]
        [Route(nameof(Insert))]
        public async Task<IActionResult> Insert([FromBody] InsertClientViewModel clientViewModel)
        {
            try
            {
                ClientDTO clientDTO = _mapper.Map<ClientDTO>(clientViewModel);

                seviceResponseDTO = await _iClientServices.Insert(clientDTO);
            }

            catch (Exception ex)
            {
                seviceResponseDTO.Sucess = false;
                seviceResponseDTO.Message = ex.GetBaseException().Message;
                _iWorkUnit.Rollback();
            }

            return Ok(seviceResponseDTO);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int idClient)
        {
            try
            {
                seviceResponseDTO = await _iClientServices.Delete(idClient);
            }

            catch (Exception ex)
            {
                seviceResponseDTO.Sucess = false;
                seviceResponseDTO.Message = ex.GetBaseException().Message;
                _iWorkUnit.Rollback();
            }

            return Ok(seviceResponseDTO);

        }
    }
}
