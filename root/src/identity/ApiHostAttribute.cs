//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Identifies an api host
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class ApiHostAttribute : Attribute
    {
        public ApiHostAttribute(string Name, ApiHostKind kind)
        {
            this.HostName = Name;
            this.HostKind = kind;
        }

        public ApiHostAttribute(ApiHostKind kind)
        {
            this.HostName = string.Empty;
            this.HostKind = kind;
        }

        public ApiHostAttribute(string Name)
            : this(Name, ApiHostKind.DirectAndGeneric)
        {
        }

        public ApiHostAttribute()
            : this(string.Empty, ApiHostKind.DirectAndGeneric)
        {
 
        }

        public string HostName {get;}

        public ApiHostKind HostKind {get;}
    }
}