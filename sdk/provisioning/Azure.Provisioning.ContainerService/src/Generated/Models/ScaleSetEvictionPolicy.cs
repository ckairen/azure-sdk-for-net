// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// The eviction policy specifies what to do with the VM when it is evicted.
/// The default is Delete. For more information about eviction see [spot
/// VMs](https://docs.microsoft.com/azure/virtual-machines/spot-vms).
/// </summary>
public enum ScaleSetEvictionPolicy
{
    /// <summary>
    /// Nodes in the underlying Scale Set of the node pool are deleted when
    /// they&apos;re evicted.
    /// </summary>
    Delete,

    /// <summary>
    /// Nodes in the underlying Scale Set of the node pool are set to the
    /// stopped-deallocated state upon eviction. Nodes in the
    /// stopped-deallocated state count against your compute quota and can
    /// cause issues with cluster scaling or upgrading.
    /// </summary>
    Deallocate,
}
