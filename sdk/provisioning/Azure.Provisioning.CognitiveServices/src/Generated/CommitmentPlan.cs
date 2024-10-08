// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// CommitmentPlan.
/// </summary>
public partial class CommitmentPlan : Resource
{
    /// <summary>
    /// The name of the commitmentPlan associated with the Cognitive Services
    /// Account.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The Kind of the resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// The geo-location where the resource lives.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Properties of Cognitive Services account commitment plan.
    /// </summary>
    public BicepValue<CommitmentPlanProperties> Properties { get => _properties; set => _properties.Assign(value); }
    private readonly BicepValue<CommitmentPlanProperties> _properties;

    /// <summary>
    /// The resource model definition representing SKU.
    /// </summary>
    public BicepValue<CognitiveServicesSku> Sku { get => _sku; set => _sku.Assign(value); }
    private readonly BicepValue<CognitiveServicesSku> _sku;

    /// <summary>
    /// Resource tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Resource Etag.
    /// </summary>
    public BicepValue<ETag> ETag { get => _eTag; }
    private readonly BicepValue<ETag> _eTag;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent CognitiveServicesAccount.
    /// </summary>
    public CognitiveServicesAccount? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<CognitiveServicesAccount> _parent;

    /// <summary>
    /// Creates a new CommitmentPlan.
    /// </summary>
    /// <param name="resourceName">Name of the CommitmentPlan.</param>
    /// <param name="resourceVersion">Version of the CommitmentPlan.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public CommitmentPlan(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.CognitiveServices/accounts/commitmentPlans", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"]);
        _properties = BicepValue<CommitmentPlanProperties>.DefineProperty(this, "Properties", ["properties"]);
        _sku = BicepValue<CognitiveServicesSku>.DefineProperty(this, "Sku", ["sku"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _eTag = BicepValue<ETag>.DefineProperty(this, "ETag", ["etag"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<CognitiveServicesAccount>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing CommitmentPlan.
    /// </summary>
    /// <param name="resourceName">Name of the CommitmentPlan.</param>
    /// <param name="resourceVersion">Version of the CommitmentPlan.</param>
    /// <returns>The existing CommitmentPlan resource.</returns>
    public static CommitmentPlan FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
