﻿using System.Text.Json;

namespace YourWeather.Rcl.Desktop.Services
{
    public class PlatformService : Rcl.Services.PlatformService
    {

        public override string GetVersion()
        {
            return base.GetVersion();
        }

        public override async Task<T> ReadJsonAsync<T>(string baseUri)
        {
            string uri = $"wwwroot/{baseUri}";
            if(!File.Exists(uri))
            {
                throw new("not find json");
            }

            using var reader = new StreamReader(uri);
            var contents = await reader.ReadToEndAsync().ConfigureAwait(false);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return JsonSerializer.Deserialize<T>(contents, options) ?? throw new("not find json");
        }
    }
}
