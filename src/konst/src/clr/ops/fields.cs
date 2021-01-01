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

    partial struct ClrQuery
    {
        /// <summary>
        /// Returns a <see cref='ClrField'/> readonly span of the fields defined by the source
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrField> fields(Type src)
            => view(src.GetFields(BF), ClrViews.field);

        [Op, Closures(Closure)]
        public static ReadOnlySpan<ClrField> fields<T>(Type src)
            => memory.recover<FieldInfo,ClrField>(src.Fields().Where(f => f.FieldType == typeof(T)));
    }
}