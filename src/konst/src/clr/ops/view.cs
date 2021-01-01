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
    using static memory;

    partial struct ClrQuery
    {
       /// <summary>
        /// Defines a <see cref='ClrModule'/> over the source
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        internal static ClrModule view(Module src)
            => src;

        /// <summary>
        /// Defines a <see cref='ClrMethod'/> over the source
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        internal static ClrMethod view(MethodInfo src)
            => src;

        /// <summary>
        /// Defines a <see cref='ClrField'/> over the source
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        internal static ClrField view(FieldInfo src)
            => src;

        /// <summary>
        /// Defines a <see cref='ClrParameter'/> over the source
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static ClrParameter view(ParameterInfo src)
            => src;

        [MethodImpl(Inline), Op]
        internal static ReadOnlySpan<V> view<S,V>(S[] src, V v = default)
            => recover<S,V>(@readonly(src));
    }
}