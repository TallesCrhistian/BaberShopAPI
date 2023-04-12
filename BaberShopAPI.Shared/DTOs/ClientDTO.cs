using BaberShopAPI.Shared.Enumerators;

namespace BaberShopAPI.Shared.Dtos
{
    public class ClientDTO
    {
        public int IdClient { get; set; }
        public bool Active { get; set; } = true;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EnumGender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Cpf { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
