//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static RootShare;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class ApiHostAttribute : Attribute
    {
        public ApiHostAttribute(string Name, ApiHostKind opkind)
        {
            this.Name = Name;
            this.OpKind = opkind;
        }

        public ApiHostAttribute(ApiHostKind opkind)
        {
            this.Name = string.Empty;
            this.OpKind = opkind;
        }

        public ApiHostAttribute(string Name)
            : this(Name, ApiHostKind.DirectAndGeneric)
        {
        }

        public ApiHostAttribute()
            : this(string.Empty, ApiHostKind.DirectAndGeneric)
        {
        }

        public string Name {get;}

        public ApiHostKind OpKind {get;}
    }
}