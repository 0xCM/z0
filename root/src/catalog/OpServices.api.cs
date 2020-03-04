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

    using static Root;

    public static class OpServiceProviders
    {
        /// <summary>
        /// Searches an assembly for types that are attributed with the provider attribute
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static IEnumerable<Type> Discover(Assembly src)
            => src.GetTypes().Where(t => t.IsAttributed<OpServiceProviderAttribute>());

        /// <summary>
        /// Searches an assembly for types that are attributed with the provider attribute
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static IOpServiceProvider Create(Type provider)
            => (IOpServiceProvider)Activator.CreateInstance(provider);
    }

    public readonly struct OpServices : IOpServiceFactory
    {
        /// <summary>
        /// Instantiates a service operation host
        /// </summary>
        /// <param name="host">The hosting type</param>
        public static IFunc Service(Type host)
            => (IFunc)Activator.CreateInstance(host);        

        /// <summary>
        /// Instantiates a strongly-typed operation host
        /// </summary>
        /// <typeparam name="S">The host type</typeparam>
        [MethodImpl(Inline)]
        public static S Service<S>()
            where S : unmanaged, IFunc
                => default(S);
    }
}