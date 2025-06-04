﻿using Blog;
using System.Text.Json.Serialization;

namespace SiteAPI.Models
{
    public class Element
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("position")]
        public int? Position { get; set; }
        [JsonPropertyName("content")]
        public string? Content { get; set; }
        [JsonPropertyName("elementType")]
        public ElementTypes ElementType { get; set; }
        [JsonPropertyName("siteId")]
        public int? SiteId { get; set; }
    }
}
