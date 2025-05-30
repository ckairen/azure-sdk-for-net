// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// The password that will be used for authenticating the token of a container
/// registry.
/// </summary>
public partial class ContainerRegistryTokenPassword : ProvisionableConstruct
{
    /// <summary>
    /// The creation datetime of the password.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn 
    {
        get { Initialize(); return _createdOn!; }
        set { Initialize(); _createdOn!.Assign(value); }
    }
    private BicepValue<DateTimeOffset>? _createdOn;

    /// <summary>
    /// The expiry datetime of the password.
    /// </summary>
    public BicepValue<DateTimeOffset> ExpireOn 
    {
        get { Initialize(); return _expireOn!; }
        set { Initialize(); _expireOn!.Assign(value); }
    }
    private BicepValue<DateTimeOffset>? _expireOn;

    /// <summary>
    /// The password name &quot;password1&quot; or &quot;password2&quot;.
    /// </summary>
    public BicepValue<ContainerRegistryTokenPasswordName> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<ContainerRegistryTokenPasswordName>? _name;

    /// <summary>
    /// The password value.
    /// </summary>
    public BicepValue<string> Value 
    {
        get { Initialize(); return _value!; }
    }
    private BicepValue<string>? _value;

    /// <summary>
    /// Creates a new ContainerRegistryTokenPassword.
    /// </summary>
    public ContainerRegistryTokenPassword()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ContainerRegistryTokenPassword.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _createdOn = DefineProperty<DateTimeOffset>("CreatedOn", ["creationTime"]);
        _expireOn = DefineProperty<DateTimeOffset>("ExpireOn", ["expiry"]);
        _name = DefineProperty<ContainerRegistryTokenPasswordName>("Name", ["name"]);
        _value = DefineProperty<string>("Value", ["value"], isOutput: true);
    }
}
