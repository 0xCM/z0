//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Konst;
    using static z;
    using Q = ApiQuery;

    partial struct Resources
    {
        /// <summary>
        /// Queries the source type for ByteSpan property getters
        /// </summary>
        /// <param name="src">The type to query</param>
        [Op]
        public static ApiMemberRes[] api(Type src)
            => src.StaticProperties()
                 .Ignore()
                  .WithPropertyType(Q.ResAccessorTypes)
                  .Select(p => p.GetGetMethod(true))
                  .Where(m  => m != null)
                  .Concrete()
                  .Select(x => new ApiMemberRes(Q.uri(src), x, Q.FormatAccessor(x.ReturnType)));

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

        /// <summary>
        /// Collects all resource accessors defined by a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static ResDeclarations[] declarations(Assembly src)
            => (from a in accessors(src).Accessors
                let t = a.Member.DeclaringType
                group a by t).Map(x => new ResDeclarations(x.Key, x.ToArray()));
    }
}