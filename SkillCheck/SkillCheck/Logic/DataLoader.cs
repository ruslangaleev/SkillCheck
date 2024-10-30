namespace SkillCheck.Logic
{
    public class DataLoader
    {
        private static readonly HttpClient _httpClient = new();

        public static async Task<string> FetchDataAsync(string url)
        {
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
