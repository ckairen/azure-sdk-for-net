// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Monitor.Query.Models
{
    internal partial class ErrorResponseAutoGenerated2
    {
        internal static ErrorResponseAutoGenerated2 DeserializeErrorResponseAutoGenerated2(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ErrorDetail error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = ErrorDetail.DeserializeErrorDetail(property.Value);
                    continue;
                }
            }
            return new ErrorResponseAutoGenerated2(error);
        }
    }
}
