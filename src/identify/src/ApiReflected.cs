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

    using static Seed;

    public readonly struct ApiReflected : IApiReflected
    {
        public static IApiReflected Service => default(ApiReflected);
    }
    
    public interface IApiReflected
    {
        /// <summary>
        /// Creates a (possibly empy) api catalog for a specified part
        /// </summary>
        /// <param name="src">The source part</param>
        IApiCatalog Catalog(IPart src)
            => ApiCatalog.Create(src);

        /// <summary>
        /// Instantiates the api hosts found in a specified assembly
        /// </summary>
        /// <param name="src">The assembly to search</param>
        IEnumerable<IApiHost> ApiHosts(Assembly src)
            => ApiHost.Hosts(src); 

        /// <summary>
        /// Searches an assembly for api host types
        /// </summary>
        /// <param name="src">The assembly to search</param>
        IEnumerable<Type> ApiHostTypes(Assembly src)
            => ApiHost.HostTypes(src);
    }
}