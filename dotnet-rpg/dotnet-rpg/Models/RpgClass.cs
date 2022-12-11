using System.Text.Json.Serialization;

namespace dotnet_rpg.Models
{
    // j.c allow the enums to appear by keyword not number
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3
    }
}
