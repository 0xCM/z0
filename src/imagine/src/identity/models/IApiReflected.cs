//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    using static Konst;

    public interface IApiReflected
    {
        /// <summary>
        /// Creates a (possibly empy) api catalog for a specified part
        /// </summary>
        /// <param name="src">The source part</param>
        IApiCatalog Catalog(IPart src)
            => ApiHosts.catalog(src);

        /// <summary>
        /// Instantiates the api hosts found in a specified assembly
        /// </summary>
        /// <param name="src">The assembly to search</param>
        IEnumerable<IApiHost> Hosts(Assembly src)
            => ApiHosts.from(src); 

        /// <summary>
        /// Searches an assembly for api host types
        /// </summary>
        /// <param name="src">The assembly to search</param>
        IEnumerable<Type> HostTypes(Assembly src)
            => ApiHosts.types(src);
    }
}