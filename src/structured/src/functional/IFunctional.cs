//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Characterizes a service that exposes serviced api operations
    /// </summary>
    public interface IFunctional
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
    /// Characterizes an F-bound polymorphic functional service factory that also encloses service host types
    /// </summary>
    /// <typeparam name="F">The factory type</typeparam>
    public interface IFunctional<F> : IFunctional
        where F : IFunctional<F>, new()
    {
        IEnumerable<Type> IFunctional.HostTypes 
            => typeof(F).GetNestedTypes().Realize<IFunc>();

        IEnumerable<MethodInfo> IFunctional.FactoryMethods 
            => from m in typeof(F).DeclaredStaticMethods()
               where m.ReturnType.Reifies(typeof(IFunc)) 
               select m;
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic functional service factory with an H-parametric enclosure
    /// </summary>
    /// <typeparam name="F">The factory type</typeparam>
    /// <typeparam name="H">The host enclosure type</typeparam>
    public interface IFunctional<F,H> : IFunctional<F>
        where F : IFunctional<F,H>, new()
    {
        IEnumerable<Type> IFunctional.HostTypes 
            => typeof(H).GetNestedTypes().Realize<IFunc>();

        IEnumerable<MethodInfo> IFunctional.FactoryMethods 
            => from m in typeof(F).DeclaredStaticMethods()
               where m.ReturnType.Reifies(typeof(IFunc)) 
               select m;
    }
}