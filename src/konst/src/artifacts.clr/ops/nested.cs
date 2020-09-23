//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Buffers;
    using System.Reflection;

    using static Konst;
    using static z;
    using static ReflectionFlags;

    partial struct ClrArtifacts
    {
        /// <summary>
        /// Returns an unfiltered <see cref='Type'/> array of the nested types defined by the source
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static Type[] nested(Type src)
            => src.GetNestedTypes(BF_All);

        /// <summary>
        /// Returns a filtered <see cref='Type'/> array of the nested types defined by the source
        /// </summary>
        /// <param name="src">The source types</param>
        /// <param name="filter">The filter to apply</param>
        [MethodImpl(Inline), Op]
        public static Type[] nested(Type src, ClrQuerySpec filter)
            => src.GetNestedTypes((BindingFlags)filter);

        /// <summary>
        /// Returns an unfiltered <see cref='TypeType'/> view of the nested types defined by the source
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<TypeView> vNested(Type src)
            => @recover<Type,TypeView>(@readonly(nested(src)));
    }
}