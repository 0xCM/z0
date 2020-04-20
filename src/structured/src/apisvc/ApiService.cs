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
    /// Defines service provider implementation predicated on service factory and enclosure types
    /// </summary>
    public readonly struct ApiService : IApiService
    {
        /// <summary>
        /// Creates a provider from the service factory that defines operations to instantiate
        /// services and an enclosing type within which the service implementations are defined
        /// </summary>
        /// <param name="factory">The service factor</param>
        /// <param name="enclosure">The outer host type</param>
        public static IApiService From(Type factory, Type enclosure)
            => new ApiService(factory, enclosure);
        
        ApiService(Type factory, Type enclosure)
        {
            this.FactoryHost = factory;
            this.HostEnclosure = enclosure;
            this.HostTypes = enclosure.GetNestedTypes().Realize<ISFuncApi>().ToArray();
            this.FactoryMethods = (from m in factory.DeclaredStaticMethods()
               where m.ReturnType.Realizes(typeof(ISFuncApi)) 
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
        IEnumerable<Type> IApiService.HostTypes
            => HostTypes;

        /// <summary>
        /// The methods defined by the factory host that intantiate services reified by the host types
        /// </summary>
        IEnumerable<MethodInfo> IApiService.FactoryMethods
            => FactoryMethods;
    }
}