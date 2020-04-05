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
    
    /// <summary>
    /// Defines service provider implementation predicated on service factory and enclosure types
    /// </summary>
    public readonly struct ApiServiceProvider : IApiServiceProvider
    {
        /// <summary>
        /// Discovers the types declared within an enclosure that define serviced api operations
        /// </summary>
        public static IEnumerable<Type> Hosts(Type enclosure)
            => enclosure.GetNestedTypes().Realize<ISFuncApi>();

        /// <summary>
        /// Discovers the methods defined by a provider that intantiate reified services
        /// </summary>
        public static IEnumerable<MethodInfo> Factories(Type factory)
            => from m in factory.DeclaredStaticMethods()
               where m.ReturnType.Realizes(typeof(ISFuncApi)) 
               select m;

        /// <summary>
        /// Creates a provider from the service factory that defines operations to instantiate
        /// services and an enclosing type within which the service implementations are defined
        /// </summary>
        /// <param name="factory">The service factor</param>
        /// <param name="enclosure">The outer host type</param>
        public static IApiServiceProvider From(Type factory, Type enclosure)
            => new ApiServiceProvider(factory, enclosure);
        
        ApiServiceProvider(Type factory, Type enclosure)
        {
            this.FactoryHost = factory;
            this.HostEnclosure = enclosure;
            this.HostTypes = Hosts(enclosure).ToArray();
            this.FactoryMethods = Factories(factory).ToArray();
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
        IEnumerable<Type> IApiServiceProvider.HostTypes
            => HostTypes;

        /// <summary>
        /// The methods defined by the factory host that intantiate services reified by the host types
        /// </summary>
        IEnumerable<MethodInfo> IApiServiceProvider.FactoryMethods
            => FactoryMethods;
    }
}