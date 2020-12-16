//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Records
    {
        [Op, Closures(Closure)]
        public static DynamicRows<T> rows<T>(ReadOnlySpan<T> src)
            where T : struct
                => rows(Records.fields<T>(), src);

        /// <summary>
        /// Allocates a <see cref='DynamicRows{T}' /> index
        /// </summary>
        /// <param name="fields">The fields declared by the defining row</param>
        /// <param name="rowcount">The number of rows to allocate</param>
        /// <typeparam name="T">The row type</typeparam>
        [Op, Closures(Closure)]
        public static DynamicRows<T> rows<T>(in RecordFields fields, uint rowcount)
            where T : struct
                => first(recover<byte,DynamicRows<T>>(span<byte>(rowsize<T>(rowcount, fields.Count))));

        [Op, Closures(Closure)]
        public static DynamicRows<T> rows<T>(in RecordFields fields, ReadOnlySpan<T> src)
            where T : struct
        {
            var count = (uint)src.Length;
            var buffer = rows<T>(fields, count);
            Records.load(fields,src,buffer);
            return buffer;
        }
    }
}