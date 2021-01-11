//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Clr
    {
        /// <summary>
        /// Returns a <see cref='ClrField'/> readonly span of the fields defined by the source
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrField> fields(Type src)
            => view(src.GetFields(BF));

        /// <summary>
        /// Returns a <see cref='ClrField'/> readonly span of the fields defined by a parametrically-identified source type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [Op, Closures(Closure)]
        public static ReadOnlySpan<ClrField> fields<T>()
            => view(typeof(T).GetFields(BF));
    }
}