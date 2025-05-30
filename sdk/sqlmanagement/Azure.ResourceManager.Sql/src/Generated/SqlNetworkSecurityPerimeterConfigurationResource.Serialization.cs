// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlNetworkSecurityPerimeterConfigurationResource : IJsonModel<SqlNetworkSecurityPerimeterConfigurationData>
    {
        void IJsonModel<SqlNetworkSecurityPerimeterConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SqlNetworkSecurityPerimeterConfigurationData>)Data).Write(writer, options);

        SqlNetworkSecurityPerimeterConfigurationData IJsonModel<SqlNetworkSecurityPerimeterConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SqlNetworkSecurityPerimeterConfigurationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SqlNetworkSecurityPerimeterConfigurationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SqlNetworkSecurityPerimeterConfigurationData IPersistableModel<SqlNetworkSecurityPerimeterConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SqlNetworkSecurityPerimeterConfigurationData>(data, options);

        string IPersistableModel<SqlNetworkSecurityPerimeterConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SqlNetworkSecurityPerimeterConfigurationData>)Data).GetFormatFromOptions(options);
    }
}
