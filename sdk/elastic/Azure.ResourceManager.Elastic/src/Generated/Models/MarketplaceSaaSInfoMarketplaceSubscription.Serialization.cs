// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Elastic.Models
{
    public partial class MarketplaceSaaSInfoMarketplaceSubscription : IUtf8JsonSerializable, IJsonModel<MarketplaceSaaSInfoMarketplaceSubscription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MarketplaceSaaSInfoMarketplaceSubscription>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MarketplaceSaaSInfoMarketplaceSubscription>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceSaaSInfoMarketplaceSubscription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MarketplaceSaaSInfoMarketplaceSubscription)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(PublisherId))
            {
                writer.WritePropertyName("publisherId"u8);
                writer.WriteStringValue(PublisherId);
            }
            if (Optional.IsDefined(OfferId))
            {
                writer.WritePropertyName("offerId"u8);
                writer.WriteStringValue(OfferId);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        MarketplaceSaaSInfoMarketplaceSubscription IJsonModel<MarketplaceSaaSInfoMarketplaceSubscription>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceSaaSInfoMarketplaceSubscription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MarketplaceSaaSInfoMarketplaceSubscription)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMarketplaceSaaSInfoMarketplaceSubscription(document.RootElement, options);
        }

        internal static MarketplaceSaaSInfoMarketplaceSubscription DeserializeMarketplaceSaaSInfoMarketplaceSubscription(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string publisherId = default;
            string offerId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisherId"u8))
                {
                    publisherId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offerId"u8))
                {
                    offerId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MarketplaceSaaSInfoMarketplaceSubscription(id, publisherId, offerId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MarketplaceSaaSInfoMarketplaceSubscription>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceSaaSInfoMarketplaceSubscription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MarketplaceSaaSInfoMarketplaceSubscription)} does not support writing '{options.Format}' format.");
            }
        }

        MarketplaceSaaSInfoMarketplaceSubscription IPersistableModel<MarketplaceSaaSInfoMarketplaceSubscription>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceSaaSInfoMarketplaceSubscription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMarketplaceSaaSInfoMarketplaceSubscription(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MarketplaceSaaSInfoMarketplaceSubscription)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MarketplaceSaaSInfoMarketplaceSubscription>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
