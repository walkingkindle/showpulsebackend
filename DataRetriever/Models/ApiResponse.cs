using System.Text.Json.Serialization;

namespace DataRetriever.Models;

public class ApiResponse
{
    [JsonPropertyName("status")]
    public string Status { get; set; }
    
    [JsonPropertyName("data")]
    public List<ShowDataDto>? Data { get; set; }
}
