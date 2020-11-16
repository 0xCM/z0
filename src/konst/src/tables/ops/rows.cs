//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    partial struct Table
    {
        /// <summary>
        /// Allocates a <see cref='TableRows{T}' /> index
        /// </summary>
        /// <param name="fields">The fields declared by the defining row</param>
        /// <param name="rowcount">The number of rows to allocate</param>
        /// <typeparam name="T">The row type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static TableRows<T> rows<T>(in TableFields fields, uint rowcount)
            where T : struct
                => first(recover<byte,TableRows<T>>(span<byte>(rowsize<T>(rowcount, fields.Count))));

        [MethodImpl(Inline)]
        public static TableRows<T> rows<T>(ReadOnlySpan<T> src)
            where T : struct
                => rows(Table.index<T>(), src);

        [MethodImpl(Inline)]
        public static TableRows<T> rows<T>(in TableFields fields, ReadOnlySpan<T> src)
            where T : struct
        {
            var count = (uint)src.Length;
            var buffer = rows<T>(fields, count);
            load(fields,src,buffer);
            return buffer;
        }
    }
}