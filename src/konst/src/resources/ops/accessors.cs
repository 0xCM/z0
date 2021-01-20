//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    partial struct Resources
    {
        /// <summary>
        /// Queries the source assemblies for ByteSpan property getters
        /// </summary>
        /// <param name="src">The assemblies to query</param>
        [MethodImpl(Inline), Op]
        public static ResAccessors accessors(Assembly[] src)
            => accessors(src.SelectMany(x => x.GetTypes()));

        /// <summary>
        /// Queries the source assembly for ByteSpan property getters
        /// </summary>
        /// <param name="src">The assembly to query</param>
        [MethodImpl(Inline), Op]
        public static ResAccessors accessors(Assembly src)
            => accessors(src.GetTypes());

        /// <summary>
        /// Queries the source types for ByteSpan property getters
        /// </summary>
        /// <param name="src">The types to query</param>
        [MethodImpl(Inline), Op]
        public static ResAccessors accessors(Type[] src)
            => src.Where(t => !t.IsInterface).SelectMany(api).Array();
    }
}