using BaberShopAPI.Shared.Enumerators;

namespace BaberShopAPI.Entities
{
    public class Client
    {
        public int IdClient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EnumGender MyProperty { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Cpf { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
