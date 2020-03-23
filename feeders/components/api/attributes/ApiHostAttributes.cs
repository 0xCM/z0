//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Identifies an api host
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class ApiHostAttribute : Attribute
    {
        public ApiHostAttribute(string name, ApiHostKind kind)
        {
            this.HostName = name;
            this.HostKind = kind;
        }

        public ApiHostAttribute(ApiHostKind kind)
        {
            this.HostName = string.Empty;
            this.HostKind = kind;
        }

        public ApiHostAttribute(string name)
            : this(name, ApiHostKind.DirectAndGeneric)
        {
        }

        public ApiHostAttribute()
            : this(string.Empty, ApiHostKind.DirectAndGeneric)
        {
 
        }

        public string HostName {get;}

        public ApiHostKind HostKind {get;}
    }

    /// <summary>
    /// Identifies an operation service provider
    /// </summary>
    public class ApiSeviceFactoryProviderAttribute : Attribute, IApiServiceProvisioner
    {
        public ApiSeviceFactoryProviderAttribute()
        {
            this.ServiceCollectionName = string.Empty;
        }

        public ApiSeviceFactoryProviderAttribute(string name)
        {
            this.ServiceCollectionName =name;
        }

        public string ServiceCollectionName {get;}
    }


}