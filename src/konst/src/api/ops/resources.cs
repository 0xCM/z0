//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Konst;
    using static z;

    partial struct ApiQuery
    {
        /// <summary>
        /// Queries the source assemblies for ByteSpan property getters
        /// </summary>
        /// <param name="src">The assemblies to query</param>
        [MethodImpl(Inline), Op]
        public static ResourceAccessors resources(Assembly[] src)
            => resources(src.SelectMany(x => x.GetTypes()));

        /// <summary>
        /// Queries the source assembly for ByteSpan property getters
        /// </summary>
        /// <param name="src">The assembly to query</param>
        [MethodImpl(Inline), Op]
        public static ResourceAccessors resources(Assembly src)
            => resources(src.GetTypes());

        /// <summary>
        /// Queries the source types for ByteSpan property getters
        /// </summary>
        /// <param name="src">The types to query</param>
        [MethodImpl(Inline), Op]
        public static ResourceAccessors resources(Type[] src)
            => src.Where(t => !t.IsInterface).SelectMany(ApiQuery.resources).Array();

        /// <summary>
        /// Queries the source type for ByteSpan property getters
        /// </summary>
        /// <param name="src">The type to query</param>
        [Op]
        public static ResourceAccessor[] resources(Type src)
            => src.StaticProperties()
                 .Ignore()
                  .WithPropertyType(ResAccessorTypes)
                  .Select(p => p.GetGetMethod(true))
                  .Where(m  => m != null)
                  .Concrete()
                  .Select(x => new ResourceAccessor(ApiQuery.uri(src), x, FormatAccessor(x.ReturnType)));
    }
}