using AutoMapper;
using BaberShopAPI.Business.Interfaces;
using BaberShopAPI.Data.Interfaces;
using BaberShopAPI.Entities;
using BaberShopAPI.Shared.Dtos;

namespace BaberShopAPI.Business
{
    public class ClienteBusiness : IClientBusiness
    {
        private readonly IMapper _mapper;
        private IClientRepository _iClientRepository;

        public ClienteBusiness(IMapper mapper, IClientRepository clientRepositorio)
        {
            _mapper = mapper;
            _iClientRepository = clientRepositorio;
        }

        public async Task<ClientDTO> Insert(ClientDTO clientDTO)
        {
            Client client = _mapper.Map<Client>(clientDTO);
            client = await _iClientRepository.Inserir(client);

            return _mapper.Map<ClientDTO>(client);
        }

        public async Task<ClientDTO> Delete(int idClient)
        {
            Client client = await _iClientRepository.Delete(idClient);
            ClientDTO clientDTO = (client != null) ? _mapper.Map<ClientDTO>(client) : new ClientDTO();

            return clientDTO;
        }
    }
}
