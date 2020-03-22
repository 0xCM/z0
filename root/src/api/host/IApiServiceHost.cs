//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IApiServiceHosts
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

    public interface IApiServiceHosts<P> : IApiServiceHosts
        where P : IApiServiceHosts<P>, new()
    {

    }

    public interface IApiServiceProvisioner
    {
        string ServiceCollectionName {get;}
    }

    /// <summary>
    /// Identifies a service host provider
    /// </summary>
    public class ApiServiceHostProviderAttribute : Attribute, IApiServiceProvisioner
    {
        public ApiServiceHostProviderAttribute()
        {
            this.ServiceCollectionName = string.Empty;
        }

        public ApiServiceHostProviderAttribute(string name)
        {
            this.ServiceCollectionName = name;
        }

        public string ServiceCollectionName {get;}
    }

}