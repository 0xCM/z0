//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Identifies an api host
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class ApiHostAttribute : Attribute
    {
        public string HostName {get;}

        public ApiHostKind HostKind {get;}        
        
        public ApiHostAttribute(string name, ApiHostKind kind)
        {
            HostName = name;
            HostKind = kind;
        }

        public ApiHostAttribute(ApiHostKind kind)
        {
            HostName = string.Empty;
            HostKind = kind;
        }

        public ApiHostAttribute(string name)
            : this(name, ApiHostKind.DirectAndGeneric)
        {
        }

        public ApiHostAttribute()
            : this(string.Empty, ApiHostKind.DirectAndGeneric)
        {
 
        }
    }
}