//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;

/// <summary>
/// Marks a type as an api data type
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class ApiDeepAttribute : ApiProviderAttribute
{
    public string Name {get;}

    public ApiDeepAttribute()
        : base(ApiProviderKind.DataType)
    {
        Name = string.Empty;
    }

    public ApiDeepAttribute(string name)
        : base(ApiProviderKind.DataType)
    {
        Name = name;
    }

    public ApiDeepAttribute(string name, bool global)
        : base(ApiProviderKind.DataType, global)
    {
        Name = name;
    }
}
