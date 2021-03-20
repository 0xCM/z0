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

    using static SFx;

    /// <summary>
    /// Characterizes a service that exposes serviced api operations
    /// </summary>
    public interface ISFxHost
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
        int HostCount
            => HostTypes.Count();

        /// <summary>
        /// Specifies whether the catalog describes any service hosts
        /// </summary>
        bool IsNonEmpty
            => HostCount != 0;
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic functional service factory that also encloses service host types
    /// </summary>
    /// <typeparam name="F">The factory type</typeparam>
    public interface ISFxHost<H> : ISFxHost
        where H : ISFxHost<H>, new()
    {
        IEnumerable<Type> ISFxHost.HostTypes
            => typeof(H).GetNestedTypes().Realize<IFunc>();

        IEnumerable<MethodInfo> ISFxHost.FactoryMethods
            => from m in typeof(H).DeclaredStaticMethods()
               where m.ReturnType.Reifies(typeof(IFunc))
               select m;
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic functional service factory with an H-parametric enclosure
    /// </summary>
    /// <typeparam name="R">The factory type</typeparam>
    /// <typeparam name="H">The host enclosure type</typeparam>
    public interface ISFxRoot<R,H> : ISFxHost<R>
        where R : ISFxRoot<R,H>, new()
    {
        IEnumerable<Type> ISFxHost.HostTypes
            => typeof(H).GetNestedTypes().Realize<IFunc>();

        IEnumerable<MethodInfo> ISFxHost.FactoryMethods
            => from m in typeof(R).DeclaredStaticMethods()
               where m.ReturnType.Reifies(typeof(IFunc))
               select m;
    }
}