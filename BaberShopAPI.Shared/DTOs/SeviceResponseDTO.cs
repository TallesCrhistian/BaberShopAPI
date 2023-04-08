using BaberShopAPI.Shared.Messages;

namespace BaberShopAPI.Shared.DTOs
{
    public class SeviceResponseDTO<T>
    {
        public T Dados { get; set; }
        public bool Sucess { get; set; } = true;
        public string Message { get; set; } = ConstantMessages.OperationCompletedWithSuccess;
    }
}
