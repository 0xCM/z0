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

    partial class XTend
    {

        /// <summary>
        /// Searches an assembly for api host types
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static IEnumerable<Type> ApiHostTypes(this Assembly src)
            => Api.HostTypes(src); 

        /// <summary>
        /// Instantiates the api hosts found in a specified assembly
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static IEnumerable<ApiHost> ApiHosts(this Assembly src)
            => Api.Hosts(src); 

        public static OpIndex<M> ToOpIndex<M>(this IEnumerable<M> src)
            where M : struct, IApiMember
                => OpIndex.From(src.Select(h => (h.Id, h)));

        public static OpIndex<M> ToOpIndex<M>(this ReadOnlySpan<M> src)
            where M : struct, IApiMember
                => OpIndex.From(src.MapArray(h => (h.Id, h)));

        public static OpIndex<M> ToOpIndex<M>(this Span<M> src)
            where M : struct, IApiMember            
               => src.ReadOnly().ToOpIndex();

    }
}