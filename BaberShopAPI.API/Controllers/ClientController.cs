using AutoMapper;
using BaberShopAPI.Application.Interfaces;
using BaberShopAPI.Data.WorkUnit.Interfaces;
using BaberShopAPI.Shared.Dtos;
using BaberShopAPI.Shared.DTOs;
using BaberShopAPI.Shared.ViewModels.Client;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BaberShopAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private SeviceResponseDTO<ClientDTO> seviceResponseDTO = new SeviceResponseDTO<ClientDTO>();
        private SeviceResponseDTO<ClientViewModel> seviceResponseViewModel = new SeviceResponseDTO<ClientViewModel>();
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
        public async Task<IActionResult> Insert([FromBody] ClientViewModel clientViewModel)
        {
            try
            {
                ClientDTO clientDTO = _mapper.Map<ClientDTO>(clientViewModel);

                seviceResponseViewModel = await _iClientServices.Insert(clientDTO);
            }

            catch (Exception ex)
            {
                seviceResponseViewModel.Sucess = false;
                seviceResponseViewModel.Message = ex.GetBaseException().Message;
                _iWorkUnit.Rollback();
            }

            return Ok(seviceResponseViewModel);
        }

        [HttpDelete]
        [Route(nameof(Delete))]
        public async Task<IActionResult> Delete(int idClient)
        {
            try
            {
                seviceResponseDTO = await _iClientServices.Delete(idClient);

                ClientViewModel clientViewModel = _mapper.Map<ClientViewModel>(seviceResponseDTO.Dados); //Criar viewModel para delete

                seviceResponseViewModel.Dados = clientViewModel;
                seviceResponseViewModel.Sucess = seviceResponseDTO.Sucess;
                seviceResponseViewModel.Message = seviceResponseDTO.Message;
            }

            catch (Exception ex)
            {
                seviceResponseViewModel.Sucess = false;
                seviceResponseViewModel.Message = ex.GetBaseException().Message;
                _iWorkUnit.Rollback();
            }

            return Ok(seviceResponseViewModel);
        }

        [HttpGet]
        [Route(nameof(Get))]
        public async Task<IActionResult> Get(int idClient)
        {
            try
            {
                seviceResponseDTO = await _iClientServices.Get(idClient);

                ClientViewModel clientViewModel = _mapper.Map<ClientViewModel>(seviceResponseDTO.Dados);

                seviceResponseViewModel.Dados = clientViewModel;
                seviceResponseViewModel.Sucess = seviceResponseDTO.Sucess;
                seviceResponseViewModel.Message = seviceResponseDTO.Message;
            }

            catch (Exception ex)
            {
                seviceResponseViewModel.Sucess = false;
                seviceResponseViewModel.Message = ex.GetBaseException().Message;
                _iWorkUnit.Rollback();
            }

            return Ok(seviceResponseViewModel);
        }
    }
}
