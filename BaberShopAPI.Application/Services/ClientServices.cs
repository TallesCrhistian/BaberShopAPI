using BaberShopAPI.Application.Interfaces;
using BaberShopAPI.Business.Interfaces;
using BaberShopAPI.Data.WorkUnit.Interfaces;
using BaberShopAPI.Shared.Dtos;
using BaberShopAPI.Shared.DTOs;
using BaberShopAPI.Shared.Messages;
using BaberShopAPI.Shared.ViewModels.Client;

namespace BaberShopAPI.Application.Services
{
    public class ClientServices : IClientServices
    {
        private SeviceResponseDTO<ClientDTO> seviceResponseDTO = new SeviceResponseDTO<ClientDTO>();
        private SeviceResponseDTO<ClientViewModel> seviceResponseView = new SeviceResponseDTO<ClientViewModel>();        
        private readonly IWorkUnit _iWorkUnit;
        private readonly IClientBusiness _iClientBusiness;

        public ClientServices(IWorkUnit iWorkUnit, IClientBusiness clientBusiness)
        {
            _iWorkUnit = iWorkUnit;
            _iClientBusiness = clientBusiness;
        }

        public async Task<SeviceResponseDTO<ClientViewModel>> Insert(ClientDTO clienteDto)
        {

            seviceResponseView.Dados = await _iClientBusiness.Insert(clienteDto);
            await _iWorkUnit.CommitAsync();


            return seviceResponseView;
        }

        public async Task<SeviceResponseDTO<ClientDTO>> Delete(int idClient)
        {
            seviceResponseDTO.Dados = await _iClientBusiness.Delete(idClient);

            if (seviceResponseDTO.Dados.IdClient == 0)
            {
                seviceResponseDTO.Message = ConstantMessages.NoRecordLocated;
            }

            await _iWorkUnit.CommitAsync();

            return seviceResponseDTO;
        }

        public async Task<SeviceResponseDTO<ClientDTO>> Get(int idClient)
        {
            seviceResponseDTO.Dados = await _iClientBusiness.Get(idClient);

            if (seviceResponseDTO.Dados == null)
            {
                seviceResponseDTO.Message = ConstantMessages.NoRecordLocated;
            }

            await _iWorkUnit.CommitAsync();

            return seviceResponseDTO;
        }
    }
}
