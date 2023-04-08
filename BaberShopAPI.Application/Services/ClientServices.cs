using BaberShopAPI.Application.Interfaces;
using BaberShopAPI.Data.WorkUnit.Interfaces;
using BaberShopAPI.Shared.Dtos;
using BaberShopAPI.Shared.DTOs;

namespace BaberShopAPI.Application.Services
{
    public class ClientServices : IClientServices
    {
        private readonly IWorkUnit _iWorkUnit;
        // private readonly IClienteNegocios _clienteNegocios;
        public ClientServices(IWorkUnit iWorkUnit)
        {
            _iWorkUnit = iWorkUnit;
        }

        public async Task<SeviceResponseDTO<ClientDTO>> Inserir(ClientDTO clientDTO)
        {
            SeviceResponseDTO<ClientDTO> seviceResponseDTO = new SeviceResponseDTO<ClientDTO>();
            try
            {
               // seviceResponseDTO.Dados = await _clienteNegocios.Inserir(clientDTO);
                await _iWorkUnit.CommitAsync();
            }
            catch (Exception ex)
            {
                seviceResponseDTO.Sucess = false;
                seviceResponseDTO.Message = ex.GetBaseException().Message;
                _iWorkUnit.Rollback();
            }
            return seviceResponseDTO;
        }
    }
}
