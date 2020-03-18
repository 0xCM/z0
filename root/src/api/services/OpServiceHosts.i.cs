//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IOpServiceHosts
    {        
        /// <summary>
        /// The known types that reify contracted operation services, potentially generic
        /// </summary>
        Type[] HostTypes {get;}

        /// <summary>
        /// Specifies the number of service hosts described by the catalog
        /// </summary>
        int HostCount => HostTypes.Length;

        /// <summary>
        /// Specifies whether the catalog describes any service hosts
        /// </summary>
        bool IsNonEmpty => HostCount != 0;
    }

    public interface IOpServiceHosts<P> : IOpServiceHosts
        where P : IOpServiceHosts<P>, new()
    {

    }

    public interface IOpServiceProvisioner
    {
        string ServiceCollectionName {get;}
    }

    /// <summary>
    /// Identifies a service host provider
    /// </summary>
    public class OpServiceHostProviderAttribute : Attribute, IOpServiceProvisioner
    {
        public OpServiceHostProviderAttribute()
        {
            this.ServiceCollectionName = string.Empty;
        }

        public OpServiceHostProviderAttribute(string name)
        {
            this.ServiceCollectionName = name;
        }

        public string ServiceCollectionName {get;}
    }

}