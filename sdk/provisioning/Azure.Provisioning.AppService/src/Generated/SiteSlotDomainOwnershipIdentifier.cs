// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// SiteSlotDomainOwnershipIdentifier.
/// </summary>
public partial class SiteSlotDomainOwnershipIdentifier : Resource
{
    /// <summary>
    /// Name of domain ownership identifier.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// String representation of the identity.
    /// </summary>
    public BicepValue<string> Value { get => _value; set => _value.Assign(value); }
    private readonly BicepValue<string> _value;

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
    /// Gets or sets a reference to the parent WebSiteSlot.
    /// </summary>
    public WebSiteSlot? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<WebSiteSlot> _parent;

    /// <summary>
    /// Creates a new SiteSlotDomainOwnershipIdentifier.
    /// </summary>
    /// <param name="resourceName">Name of the SiteSlotDomainOwnershipIdentifier.</param>
    /// <param name="resourceVersion">Version of the SiteSlotDomainOwnershipIdentifier.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public SiteSlotDomainOwnershipIdentifier(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Web/sites/slots/domainOwnershipIdentifiers", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _value = BicepValue<string>.DefineProperty(this, "Value", ["properties", "id"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<WebSiteSlot>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing SiteSlotDomainOwnershipIdentifier.
    /// </summary>
    /// <param name="resourceName">Name of the SiteSlotDomainOwnershipIdentifier.</param>
    /// <param name="resourceVersion">Version of the SiteSlotDomainOwnershipIdentifier.</param>
    /// <returns>The existing SiteSlotDomainOwnershipIdentifier resource.</returns>
    public static SiteSlotDomainOwnershipIdentifier FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
