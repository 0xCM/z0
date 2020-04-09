//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    public static partial class Api
    {
        /// <summary>
        /// Selects the host-attributed types from an assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        public static IEnumerable<Type> HostTypes(Assembly src)
            => src.GetTypes().Tagged<ApiHostAttribute>();

        /// <summary>
        /// Instantiates the api hosts defined in a .net assembly
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static IEnumerable<ApiHost> Hosts(Assembly src)
            => HostTypes(src).Select(h => ApiHost.Define(h.Assembly.Id(), h));

        /// <summary>
        /// Creates a (possibly empy) api catalog for the source part
        /// </summary>
        /// <param name="src">The part to catalog</param>
        public static IApiCatalog ApiCatalog(this IPart src)
            => (IApiCatalog)ApiCatalogProvider.Define(src.Id, src.Owner, new ApiCatalog(src.Owner, src.Id, src.ResourceProvider));        
    }
}