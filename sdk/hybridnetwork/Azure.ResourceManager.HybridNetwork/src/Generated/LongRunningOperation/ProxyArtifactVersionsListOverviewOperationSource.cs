// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.HybridNetwork.Models;

namespace Azure.ResourceManager.HybridNetwork
{
    internal class ProxyArtifactVersionsListOverviewOperationSource : IOperationSource<ProxyArtifactVersionsListOverview>
    {
        ProxyArtifactVersionsListOverview IOperationSource<ProxyArtifactVersionsListOverview>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return ProxyArtifactVersionsListOverview.DeserializeProxyArtifactVersionsListOverview(document.RootElement);
        }

        async ValueTask<ProxyArtifactVersionsListOverview> IOperationSource<ProxyArtifactVersionsListOverview>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return ProxyArtifactVersionsListOverview.DeserializeProxyArtifactVersionsListOverview(document.RootElement);
        }
    }
}
