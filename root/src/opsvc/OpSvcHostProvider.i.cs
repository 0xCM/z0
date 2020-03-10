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
    /// Identifies an operation service provider
    /// </summary>
    public class OpSvcHostProviderAttribute : Attribute, IOpSvcProvisioner
    {
        public OpSvcHostProviderAttribute()
        {
            this.ServiceCollectionName = string.Empty;
        }

        public OpSvcHostProviderAttribute(string name)
        {
            this.ServiceCollectionName = name;
        }

        public string ServiceCollectionName {get;}
    }

    public interface IOpSvcHostProvider
    {        
        /// <summary>
        /// The known types that reify contracted operation services, potentially generic
        /// </summary>
        Type[] ServiceHostTypes {get;}

        /// <summary>
        /// Specifies the number of service hosts described by the catalog
        /// </summary>
        int ServiceHostCount => ServiceHostTypes.Length;

        /// <summary>
        /// Specifies whether the catalog describes any service hosts
        /// </summary>
        bool HasServiceHostContent => ServiceHostCount != 0;
    }

    public interface IOpSvcHostProvider<P> : IOpSvcHostProvider
        where P : IOpSvcHostProvider<P>, new()
    {

    }
}