using BaberShopAPI.Shared.Enumerators;

namespace BaberShopAPI.Shared.ViewModels.Client
{
    public class ClientViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EnumGender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Cpf { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
