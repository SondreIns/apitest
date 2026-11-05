using System.Text.Json.Serialization;

namespace apitest;

public record Flags(
    [property: JsonPropertyName("nsfw")] bool nsfw,
    [property: JsonPropertyName("religious")] bool religious,
    [property: JsonPropertyName("political")] bool political,
    [property: JsonPropertyName("racist")] bool racist,
    [property: JsonPropertyName("sexist")] bool sexist,
    [property: JsonPropertyName("explicit")] bool @explicit
);

public record Root(
    [property: JsonPropertyName("error")] bool error,
    [property: JsonPropertyName("category")] string category,
    [property: JsonPropertyName("type")] string type,
    [property: JsonPropertyName("setup")] string setup,
    [property: JsonPropertyName("delivery")] string delivery,
    [property: JsonPropertyName("flags")] Flags flags,
    [property: JsonPropertyName("id")] int id,
    [property: JsonPropertyName("safe")] bool safe,
    [property: JsonPropertyName("lang")] string lang
);
