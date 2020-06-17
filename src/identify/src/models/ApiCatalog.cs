//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Konst;

    public readonly struct ApiCatalog : IApiCatalog
    {
        [MethodImpl(Inline)]
        public static IApiCatalog Create(IPart src)
            => new ApiCatalog(src);

        /// <summary>
        /// The identity of the assembly that defines and owns the catalog
        /// </summary>
        public PartId PartId {get;}

        /// <summary>
        /// The assembly that defines and owns the catalog
        /// </summary>
        public Assembly Part {get;}

        /// <summary>
        /// The api hosts known to the catalog
        /// </summary>
        public ApiHost[] ApiHosts {get;}

        public ResourceIndex Resources  {get;}

        public Type[] FunFactories {get;}

        public ApiHost[] GenericApiHosts {get;}

        public ApiHost[] DirectApiHosts {get;}

        [MethodImpl(Inline)]
        ApiCatalog(IPart src)
            : this(src.Owner, src.Id)
        {
            
        }                            

        ApiCatalog(Assembly source, PartId id)
        {
            PartId = id;
            Part = source;
            ApiHosts = ApiHost.HostTypes(Part).Select(t => ApiHost.Define(id, t)).ToArray();
            Resources = ResourceIndex.Empty;
            DirectApiHosts = ApiHosts.Where(h => h.HostKind.DefinesDirectOps()).ToArray();
            GenericApiHosts = ApiHosts.Where(h => h.HostKind.DefinesGenericOps()).ToArray();
            FunFactories = FactoryTypes(Part).ToArray();            
        }

        /// <summary>
        /// Searches an assembly for types that are attributed with the provider attribute
        /// </summary>
        /// <param name="src">The assembly to search</param>
        static IEnumerable<Type> FactoryTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<FunctionalServiceAttribute>());
    }
}