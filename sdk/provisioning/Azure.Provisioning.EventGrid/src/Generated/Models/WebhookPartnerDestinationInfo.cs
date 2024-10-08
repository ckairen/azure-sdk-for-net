// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// Information about the WebHook of the partner destination.
/// </summary>
public partial class WebhookPartnerDestinationInfo : PartnerDestinationInfo
{
    /// <summary>
    /// The URL that represents the endpoint of the partner destination.
    /// </summary>
    public BicepValue<Uri> EndpointUri { get => _endpointUri; set => _endpointUri.Assign(value); }
    private readonly BicepValue<Uri> _endpointUri;

    /// <summary>
    /// The base URL that represents the endpoint of the partner destination.
    /// </summary>
    public BicepValue<Uri> EndpointBaseUri { get => _endpointBaseUri; set => _endpointBaseUri.Assign(value); }
    private readonly BicepValue<Uri> _endpointBaseUri;

    /// <summary>
    /// Partner client authentication             Please note
    /// Azure.ResourceManager.EventGrid.Models.PartnerClientAuthentication is
    /// the base class. According to the scenario, a derived class of the base
    /// class might need to be assigned here, or this property needs to be
    /// casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.EventGrid.Models.AzureADPartnerClientAuthentication.
    /// </summary>
    public BicepValue<PartnerClientAuthentication> ClientAuthentication { get => _clientAuthentication; set => _clientAuthentication.Assign(value); }
    private readonly BicepValue<PartnerClientAuthentication> _clientAuthentication;

    /// <summary>
    /// Creates a new WebhookPartnerDestinationInfo.
    /// </summary>
    public WebhookPartnerDestinationInfo() : base()
    {
        BicepValue<string>.DefineProperty(this, "endpointType", ["endpointType"], defaultValue: "WebHook");
        _endpointUri = BicepValue<Uri>.DefineProperty(this, "EndpointUri", ["properties", "endpointUrl"]);
        _endpointBaseUri = BicepValue<Uri>.DefineProperty(this, "EndpointBaseUri", ["properties", "endpointBaseUrl"]);
        _clientAuthentication = BicepValue<PartnerClientAuthentication>.DefineProperty(this, "ClientAuthentication", ["properties", "clientAuthentication"]);
    }
}
