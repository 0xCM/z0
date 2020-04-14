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

    public static class ApiServices
    {
        /// <summary>
        /// Searches an assembly for types that are attributed with the provider attribute
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static IEnumerable<Type> ProviderTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<ApiServiceProviderAttribute>());

        /// <summary>
        /// Creates a service provider reified by a specified type
        /// </summary>
        /// <param name="provider">The provider type</param>
        public static IApiService Provider(Type provider)
            => (IApiService)Activator.CreateInstance(provider);

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
        public static S ApiSvc<S>()
            where S : unmanaged, ISFuncApi    
                => default(S);        
    }
}