using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace api.Models;
public class Book
    {
        public readonly string CollectionName = "books";

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        
        [BsonElement("Name")]
        [JsonPropertyName("Name")]
        public string BookName { get; set; } = null!;
        public decimal price { get; set; }
        public Category Category { get; set; } = null!;
        public string Author { get; set; } = null!;

    }