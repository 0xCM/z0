//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    partial struct Clr
    {
        /// <summary>
        /// Returns a <see cref='ClrFieldAdapter'/> readonly span of the fields defined by the source
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrFieldAdapter> fields(Type src)
            => adapt(fields(src, out var _));

        [MethodImpl(Inline), Op]
        public static FieldInfo[] fields(Type src, out FieldInfo[] dst)
            => dst = src.GetFields(BF);

        /// <summary>
        /// Returns a <see cref='ClrFieldAdapter'/> readonly span of the fields defined by a parametrically-identified source type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrFieldAdapter> fields<T>()
            => adapt(typeof(T).GetFields(BF));
    }
}