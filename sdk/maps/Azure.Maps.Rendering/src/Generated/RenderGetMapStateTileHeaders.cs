// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.Maps.Rendering
{
    internal partial class RenderGetMapStateTileHeaders
    {
        private readonly Response _response;
        public RenderGetMapStateTileHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> The content-type for the response. </summary>
        public string ContentType => _response.Headers.TryGetValue("Content-Type", out string value) ? value : null;
    }
}
