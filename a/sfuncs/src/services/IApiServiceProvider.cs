//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Characterizes a service that exposes serviced api operations
    /// </summary>
    public interface IApiServiceProvider
    {        
        /// <summary>
        /// The known types that reify contracted operation services, potentially generic
        /// </summary>
        IEnumerable<Type> HostTypes {get;}

        /// <summary>
        /// The methods that instantiate services reified by the hosts
        /// </summary>
        IEnumerable<MethodInfo> FactoryMethods {get;}

        /// <summary>
        /// Specifies the number of service hosts described by the catalog
        /// </summary>
        int HostCount => HostTypes.Count();

        /// <summary>
        /// Specifies whether the catalog describes any service hosts
        /// </summary>
        bool IsNonEmpty => HostCount != 0;
    }

    /// <summary>
    /// Characterizes an enclosure-parametric service that exposes serviced api operations
    /// </summary>
    /// <typeparam name="H">The outer host within which service reifications are implemented</typeparam>
    public interface IApiServiceProvider<H> : IApiServiceProvider
    {
        IEnumerable<Type> IApiServiceProvider.HostTypes 
            => typeof(H).GetNestedTypes().Realize<ISFuncApi>();

        IEnumerable<MethodInfo> IApiServiceProvider.FactoryMethods 
            => from m in GetType().DeclaredStaticMethods()
               where m.ReturnType.Realizes(typeof(ISFuncApi)) 
               select m;
    }
}