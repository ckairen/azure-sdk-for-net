// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// Gets the status of the cognitive services account at the time the operation
/// was called.
/// </summary>
public enum ServiceAccountProvisioningState
{
    /// <summary>
    /// Accepted.
    /// </summary>
    Accepted,

    /// <summary>
    /// Creating.
    /// </summary>
    Creating,

    /// <summary>
    /// Deleting.
    /// </summary>
    Deleting,

    /// <summary>
    /// Moving.
    /// </summary>
    Moving,

    /// <summary>
    /// Failed.
    /// </summary>
    Failed,

    /// <summary>
    /// Succeeded.
    /// </summary>
    Succeeded,

    /// <summary>
    /// ResolvingDNS.
    /// </summary>
    [DataMember(Name = "ResolvingDNS")]
    ResolvingDns,
}
