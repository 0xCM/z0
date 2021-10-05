//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using R = System.Reflection;

    using static Root;
    using static core;

    partial struct ClrModels
    {
        /// <summary>
        /// Returns a <see cref='ClrFieldAdapter'/> readonly span of the fields defined by the source
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrFieldAdapter> fields(Type src)
            => adapt(src.GetFields(BF));

        /// <summary>
        /// Returns a <see cref='ClrFieldAdapter'/> readonly span of the fields defined by a parametrically-identified source type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [Op, Closures(Closure)]
        public static ReadOnlySpan<ClrFieldAdapter> fields<T>()
            => adapt(typeof(T).GetFields(BF));
    }
}