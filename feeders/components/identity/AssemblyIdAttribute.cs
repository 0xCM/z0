//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Assembly)]
public class AssemblyIdAttribute : Attribute
{
    
    public AssemblyIdAttribute(object id)
    {
        Id = (AssemblyId)id;
    }

    public AssemblyId Id {get;}
}
