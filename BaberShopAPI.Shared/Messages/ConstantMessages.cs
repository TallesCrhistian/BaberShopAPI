using System.Numerics;

namespace BaberShopAPI.Shared.Messages
{
    public static class ConstantMessages
    {
        public const string OperationCompletedWithSuccess = "Operação concluída com sucesso!";
        public const string NoRecordLocated = "Nenhum registro localizado!";
        public const string ClientNotLocated = "Cliente não localizado";
        public const string OrderNotLocated = "Pedido não encontrado";
        public const string InvalidPassword = "Senha inválida";
        public const string NoRecordSelected = "Nenhum registro selecionado!";
        public const string ItWasNotPossibleToCompleteTheoOperation = "Não foi possivel concluir operação";

        public static string EmailAlreadyExists(string email) => $"Email {email} já cadastrado!";
    }
}

