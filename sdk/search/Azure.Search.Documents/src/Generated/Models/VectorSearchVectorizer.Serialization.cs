// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Search.Documents.Models;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class VectorSearchVectorizer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WriteEndObject();
        }

        internal static VectorSearchVectorizer DeserializeVectorSearchVectorizer(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "azureOpenAI": return AzureOpenAIVectorizer.DeserializeAzureOpenAIVectorizer(element);
                    case "customWebApi": return CustomVectorizer.DeserializeCustomVectorizer(element);
                }
            }
            return UnknownVectorSearchVectorizer.DeserializeUnknownVectorSearchVectorizer(element);
        }
    }
}
