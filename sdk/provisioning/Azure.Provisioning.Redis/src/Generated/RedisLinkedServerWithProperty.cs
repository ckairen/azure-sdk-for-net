// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Redis;

/// <summary>
/// RedisLinkedServerWithProperty.
/// </summary>
public partial class RedisLinkedServerWithProperty : Resource
{
    /// <summary>
    /// The name of the linked server that is being added to the Redis cache.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Fully qualified resourceId of the linked redis cache.
    /// </summary>
    public BicepValue<ResourceIdentifier> LinkedRedisCacheId { get => _linkedRedisCacheId; set => _linkedRedisCacheId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _linkedRedisCacheId;

    /// <summary>
    /// Location of the linked redis cache.
    /// </summary>
    public BicepValue<AzureLocation> LinkedRedisCacheLocation { get => _linkedRedisCacheLocation; set => _linkedRedisCacheLocation.Assign(value); }
    private readonly BicepValue<AzureLocation> _linkedRedisCacheLocation;

    /// <summary>
    /// Role of the linked server.
    /// </summary>
    public BicepValue<RedisLinkedServerRole> ServerRole { get => _serverRole; set => _serverRole.Assign(value); }
    private readonly BicepValue<RedisLinkedServerRole> _serverRole;

    /// <summary>
    /// The unchanging DNS name which will always point to current geo-primary
    /// cache among the linked redis caches for seamless Geo Failover
    /// experience.
    /// </summary>
    public BicepValue<string> GeoReplicatedPrimaryHostName { get => _geoReplicatedPrimaryHostName; }
    private readonly BicepValue<string> _geoReplicatedPrimaryHostName;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The changing DNS name that resolves to the current geo-primary cache
    /// among the linked redis caches before or after the Geo Failover.
    /// </summary>
    public BicepValue<string> PrimaryHostName { get => _primaryHostName; }
    private readonly BicepValue<string> _primaryHostName;

    /// <summary>
    /// Terminal state of the link between primary and secondary redis cache.
    /// </summary>
    public BicepValue<string> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<string> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent RedisResource.
    /// </summary>
    public RedisResource? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<RedisResource> _parent;

    /// <summary>
    /// Creates a new RedisLinkedServerWithProperty.
    /// </summary>
    /// <param name="resourceName">Name of the RedisLinkedServerWithProperty.</param>
    /// <param name="resourceVersion">Version of the RedisLinkedServerWithProperty.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public RedisLinkedServerWithProperty(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Cache/redis/linkedServers", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _linkedRedisCacheId = BicepValue<ResourceIdentifier>.DefineProperty(this, "LinkedRedisCacheId", ["properties", "linkedRedisCacheId"], isRequired: true);
        _linkedRedisCacheLocation = BicepValue<AzureLocation>.DefineProperty(this, "LinkedRedisCacheLocation", ["properties", "linkedRedisCacheLocation"], isRequired: true);
        _serverRole = BicepValue<RedisLinkedServerRole>.DefineProperty(this, "ServerRole", ["properties", "serverRole"], isRequired: true);
        _geoReplicatedPrimaryHostName = BicepValue<string>.DefineProperty(this, "GeoReplicatedPrimaryHostName", ["properties", "geoReplicatedPrimaryHostName"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _primaryHostName = BicepValue<string>.DefineProperty(this, "PrimaryHostName", ["properties", "primaryHostName"], isOutput: true);
        _provisioningState = BicepValue<string>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<RedisResource>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing RedisLinkedServerWithProperty.
    /// </summary>
    /// <param name="resourceName">Name of the RedisLinkedServerWithProperty.</param>
    /// <param name="resourceVersion">Version of the RedisLinkedServerWithProperty.</param>
    /// <returns>The existing RedisLinkedServerWithProperty resource.</returns>
    public static RedisLinkedServerWithProperty FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
