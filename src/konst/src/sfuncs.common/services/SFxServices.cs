//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct SFxServices
    {
        /// <summary>
        /// Instantiates a service operation host
        /// </summary>
        /// <param name="host">The hosting type</param>
        [Op]
        public static IFunc create(Type host)
            => (IFunc)Activator.CreateInstance(host);

        /// <summary>
        /// Creates a service provider reified by a specified type
        /// </summary>
        /// <param name="provider">The provider type</param>
        [Op]
        public static ISFxHost host(Type provider)
            => (ISFxHost)Activator.CreateInstance(provider);

        /// <summary>
        /// Creates a provider from the service factory that defines operations to instantiate
        /// services and an enclosing type within which the service implementations are defined
        /// </summary>
        /// <param name="factory">The service factor</param>
        /// <param name="enclosure">The outer host type</param>
        [MethodImpl(Inline), Op]
        public static ISFxHost host(Type factory, Type enclosure)
            => new SFxHost(factory, enclosure);

        [Op]
        public static ISFxHost[] hosts(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<FunctionalServiceAttribute>()).Select(host);
    }
}