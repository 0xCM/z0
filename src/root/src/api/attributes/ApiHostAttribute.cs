//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;

using Z0;

/// <summary>
/// Identifies an api host
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class ApiHostAttribute : ApiProviderAttribute
{

    public string HostName {get;}

    public ApiSetKind ApiSet {get;}

    public ApiHostAttribute(string name)
        : base(ApiProviderKind.Stateless)
    {
        HostName = name;
    }

    public ApiHostAttribute(string name, bool global)
        : base(ApiProviderKind.Stateless, global)
    {
        HostName = name;
    }

    public ApiHostAttribute(string name, ApiSetKind apiset)
        : base(ApiProviderKind.Stateless)
    {
        HostName = name;
        ApiSet = apiset;
    }

    public ApiHostAttribute(ApiSetKind apiset)
        : this(string.Empty)
    {
        ApiSet = apiset;
    }

    public ApiHostAttribute()
        : this(string.Empty)
    {

    }
}
