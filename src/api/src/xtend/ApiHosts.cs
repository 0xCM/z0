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

    partial class XTend
    {
        /// <summary>
        /// Instantiates the api hosts found in a specified assembly
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static IEnumerable<IApiHost> ApiHosts(this Assembly src)
            => Api.Hosts(src); 

        /// <summary>
        /// Searches an assembly for api host types
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static IEnumerable<Type> ApiHostTypes(this Assembly src)
            => Api.HostTypes(src); 
    }
}