//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Konst;

    public interface TApiReflected
    {
        /// <summary>
        /// Creates a (possibly empy) api catalog for a specified part
        /// </summary>
        /// <param name="src">The source part</param>
        IPartCatalog Catalog(IPart src)
            => ApiHosts.catalog(src);

        /// <summary>
        /// Searches an assembly for attribute-identified data types
        /// </summary>
        /// <param name="src">The assembly to search</param>
        ApiDataType[] DataTypes(Assembly src)
            => ApiHosts.ApiDataTypes(src);

        ApiHost[] Hosts(Assembly src)
            => ApiHosts.Hosts(src); 
    }
}