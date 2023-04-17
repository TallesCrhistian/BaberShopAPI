using BaberShopAPI.Shared.Enumerators;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BaberShopAPI.Data.Translators
{
    public class StatusValueConverter : ValueConverter<string, EnumGender>
    {
        public StatusValueConverter() : base(
            v => (EnumGender)Enum.Parse(typeof(EnumGender), v),
            v => v.ToString())
        { }
    }
}
