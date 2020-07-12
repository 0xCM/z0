//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiHosts
    {
        [MethodImpl(Inline)]
        public static IApiHost<H> from<H>()
            where H : IApiHost<H>, new()
                => new H();

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="FunctionalServiceAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static Type[] funfacts(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<FunctionalServiceAttribute>());

        /// <summary>
        /// Selects the host-attributed types from an assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        public static Type[] types(Assembly src)
            => src.GetTypes().Tagged<ApiHostAttribute>();

        /// <summary>
        /// Instantiates the api hosts defined in a .net assembly
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static IApiHost[] from(Assembly src)
            => types(src).Select(h => from(h.Assembly.Id(), h) as IApiHost);    

        public static ApiHost from(PartId id, Type t)
        {
            var attrib = t.Tag<ApiHostAttribute>();
            var name =  text.ifblank(attrib.MapValueOrDefault(a => a.HostName, t.Name),t.Name).ToLower();
            var kind = attrib.MapValueOrDefault(a => a.HostKind, ApiHostKind.DirectAndGeneric);
            var uri = ApiHostUri.Define(id, name);
            return new ApiHost(name, kind, id, uri, t);
        }

        public static ApiCatalog catalog(IPart part)            
        {
            var hosts = types(part.Owner).Select(t => from(part.Id, t));
            return new ApiCatalog(
                PartId: part.Id,
                Owner: part.Owner,
                Hosts: hosts,
                FunFactories: funfacts(part.Owner),
                DirectHosts: hosts.Where(h => h.HostKind.DefinesDirectOps()),
                GenericHosts: hosts.Where(h => h.HostKind.DefinesGenericOps())
                );
        }
    }
}