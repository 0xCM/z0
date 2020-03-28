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

    using static SFuncs;

    public static class ApiServices
    {
        /// <summary>
        /// Discovers the types declared within an enclosure that define serviced api operations
        /// </summary>
        public static IEnumerable<Type> HostTypes(Type enclosure)
            => ApiServiceProvider.Hosts(enclosure);

        /// <summary>
        /// Discovers the methods defined by a provider that intantiate reified services
        /// </summary>
        public static IEnumerable<MethodInfo> FactoryMethods(Type provider)
            => ApiServiceProvider.Factories(provider);

        /// <summary>
        /// Searches an assembly for types that are attributed with the provider attribute
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static IEnumerable<Type> ProviderTypes(Assembly src)
            => src.GetTypes().Where(t => t.IsAttributed<ApiServiceProviderAttribute>());

        /// <summary>
        /// Creates a service provider reified by a specified type
        /// </summary>
        /// <param name="provider">The provider type</param>
        public static IApiServiceProvider Provider(Type provider)
            => (IApiServiceProvider)Activator.CreateInstance(provider);

        /// <summary>
        /// Instantiates a service operation host
        /// </summary>
        /// <param name="host">The hosting type</param>
        public static ISFuncApi Service(Type host)
            => (ISFuncApi)Activator.CreateInstance(host);        

        /// <summary>
        /// Instantiates a strongly-typed operation host
        /// </summary>
        /// <typeparam name="S">The host type</typeparam>
        [MethodImpl(Inline)]
        public static S Service<S>()
            where S : unmanaged, ISFuncApi    
                => default(S);        
    }
}