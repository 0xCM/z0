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

    using static Seed;

    /// <summary>
    /// Reifies a functional service factory that also serves as a host enclosure
    /// </summary>
    /// <typeparam name="F">The factory type</typeparam>
    public readonly struct Functional<F> : IFunctional<F>
        where F : IFunctional<F>, new()
    {


    }

    /// <summary>
    /// Reifies a functional service factory with an H-parametric enclosure
    /// </summary>
    /// <typeparam name="F">The factory type</typeparam>
    /// <typeparam name="H">The host enclosure type</typeparam>
    public readonly struct Functional<S,H> : IFunctional<S,H>
        where S : IFunctional<S,H>, new()
    {

        
    }

    /// <summary>
    /// Defines service provider implementation predicated on service factory and enclosure types
    /// </summary>
    public readonly struct Functional : IFunctional
    {
        /// <summary>
        /// Creates a provider from the service factory that defines operations to instantiate
        /// services and an enclosing type within which the service implementations are defined
        /// </summary>
        /// <param name="factory">The service factor</param>
        /// <param name="enclosure">The outer host type</param>
        public static IFunctional From(Type factory, Type enclosure)
            => new Functional(factory, enclosure);

        public static IFunctional<S> From<S>()
            where S : IFunctional<S>, new()
                => default(Functional<S>);

        /// <summary>
        /// Creates a functional predicated on parametric factory and host enclosure types
        /// </summary>
        /// <typeparam name="F">The factory type</typeparam>
        /// <typeparam name="H">The host enclosure type</typeparam>
        public static IFunctional<F,H> From<F,H>()
            where F : IFunctional<F,H>, new()
                => default(Functional<F,H>);

        /// <summary>
        /// Searches an assembly for types that are attributed with the provider attribute
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static IEnumerable<Type> FactoryTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<FunctionalServiceAttribute>());

        /// <summary>
        /// Creates a service provider reified by a specified type
        /// </summary>
        /// <param name="provider">The provider type</param>
        public static IFunctional Factory(Type provider)
            => (IFunctional)Activator.CreateInstance(provider);

        /// <summary>
        /// Instantiates a service operation host
        /// </summary>
        /// <param name="host">The hosting type</param>
        public static IFunc Function(Type host)
            => (IFunc)Activator.CreateInstance(host);              

        
        Functional(Type factory, Type enclosure)
        {
            this.FactoryHost = factory;
            this.HostEnclosure = enclosure;
            this.HostTypes = enclosure.GetNestedTypes().Realize<IFunc>().ToArray();
            this.FactoryMethods = (from m in factory.DeclaredStaticMethods()
               where m.ReturnType.Reifies(typeof(IFunc)) 
               select m).ToArray();
        }

        /// <summary>
        /// The types declared within the enclosure that define serviced api operations
        /// </summary>
        public readonly Type[] HostTypes;

        /// <summary>
        /// The methods defined by the factory host that intantiate services reified by the host types
        /// </summary>
        public readonly MethodInfo[] FactoryMethods;

        /// <summary>
        /// The type that defines the service factory operations
        /// </summary>
        public Type FactoryHost {get;}

        /// <summary>
        /// The type into which api service refications are nested
        /// </summary>
        public Type HostEnclosure {get;}

        /// <summary>
        /// The types declared within the enclosure that define serviced api operations
        /// </summary>
        IEnumerable<Type> IFunctional.HostTypes
            => HostTypes;

        /// <summary>
        /// The methods defined by the factory host that intantiate services reified by the host types
        /// </summary>
        IEnumerable<MethodInfo> IFunctional.FactoryMethods
            => FactoryMethods;
    }
}