using System.Text.Json;

namespace WiredBrainCoffee.StorageApp.Entities
{
    public static class EntityExtensions
    {
        public static T? Copy<T>(this T itemCopy)
        {
            var json = JsonSerializer.Serialize<T>(itemCopy);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
