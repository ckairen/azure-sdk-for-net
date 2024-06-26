// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis
{
    internal class HealthcareApisWorkspacePrivateEndpointConnectionOperationSource : IOperationSource<HealthcareApisWorkspacePrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal HealthcareApisWorkspacePrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        HealthcareApisWorkspacePrivateEndpointConnectionResource IOperationSource<HealthcareApisWorkspacePrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = HealthcareApisPrivateEndpointConnectionData.DeserializeHealthcareApisPrivateEndpointConnectionData(document.RootElement);
            return new HealthcareApisWorkspacePrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<HealthcareApisWorkspacePrivateEndpointConnectionResource> IOperationSource<HealthcareApisWorkspacePrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = HealthcareApisPrivateEndpointConnectionData.DeserializeHealthcareApisPrivateEndpointConnectionData(document.RootElement);
            return new HealthcareApisWorkspacePrivateEndpointConnectionResource(_client, data);
        }
    }
}
