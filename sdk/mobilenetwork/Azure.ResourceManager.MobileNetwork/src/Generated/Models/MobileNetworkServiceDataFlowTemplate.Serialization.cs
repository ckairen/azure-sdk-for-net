// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkServiceDataFlowTemplate : IUtf8JsonSerializable, IJsonModel<MobileNetworkServiceDataFlowTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MobileNetworkServiceDataFlowTemplate>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MobileNetworkServiceDataFlowTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkServiceDataFlowTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkServiceDataFlowTemplate)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("templateName"u8);
            writer.WriteStringValue(TemplateName);
            writer.WritePropertyName("direction"u8);
            writer.WriteStringValue(Direction.ToString());
            writer.WritePropertyName("protocol"u8);
            writer.WriteStartArray();
            foreach (var item in Protocol)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("remoteIpList"u8);
            writer.WriteStartArray();
            foreach (var item in RemoteIPList)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Ports))
            {
                writer.WritePropertyName("ports"u8);
                writer.WriteStartArray();
                foreach (var item in Ports)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        MobileNetworkServiceDataFlowTemplate IJsonModel<MobileNetworkServiceDataFlowTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkServiceDataFlowTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkServiceDataFlowTemplate)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkServiceDataFlowTemplate(document.RootElement, options);
        }

        internal static MobileNetworkServiceDataFlowTemplate DeserializeMobileNetworkServiceDataFlowTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string templateName = default;
            MobileNetworkSdfDirectionS direction = default;
            IList<string> protocol = default;
            IList<string> remoteIPList = default;
            IList<string> ports = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("templateName"u8))
                {
                    templateName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("direction"u8))
                {
                    direction = new MobileNetworkSdfDirectionS(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    protocol = array;
                    continue;
                }
                if (property.NameEquals("remoteIpList"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    remoteIPList = array;
                    continue;
                }
                if (property.NameEquals("ports"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ports = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MobileNetworkServiceDataFlowTemplate(
                templateName,
                direction,
                protocol,
                remoteIPList,
                ports ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TemplateName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  templateName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TemplateName))
                {
                    builder.Append("  templateName: ");
                    if (TemplateName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TemplateName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TemplateName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Direction), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  direction: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  direction: ");
                builder.AppendLine($"'{Direction.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Protocol), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  protocol: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Protocol))
                {
                    if (Protocol.Any())
                    {
                        builder.Append("  protocol: ");
                        builder.AppendLine("[");
                        foreach (var item in Protocol)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RemoteIPList), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  remoteIpList: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(RemoteIPList))
                {
                    if (RemoteIPList.Any())
                    {
                        builder.Append("  remoteIpList: ");
                        builder.AppendLine("[");
                        foreach (var item in RemoteIPList)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Ports), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  ports: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Ports))
                {
                    if (Ports.Any())
                    {
                        builder.Append("  ports: ");
                        builder.AppendLine("[");
                        foreach (var item in Ports)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MobileNetworkServiceDataFlowTemplate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkServiceDataFlowTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkServiceDataFlowTemplate)} does not support writing '{options.Format}' format.");
            }
        }

        MobileNetworkServiceDataFlowTemplate IPersistableModel<MobileNetworkServiceDataFlowTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkServiceDataFlowTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMobileNetworkServiceDataFlowTemplate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkServiceDataFlowTemplate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MobileNetworkServiceDataFlowTemplate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
