//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct Records
    {
        /// <summary>
        /// Loads a <see cref='DynamicRows{T}' /> index from a specified source <see cref='ReadOnlySpan{T}'/>
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The record type</typeparam>
        [Op, Closures(Closure)]
        public static DynamicRows<T> rows<T>(ReadOnlySpan<T> src)
            where T : struct
                => rows(Records.fields<T>(), src);

        /// <summary>
        /// Loads a <see cref='DynamicRows{T}'/> sequence from a specified source <see cref='ReadOnlySpan{T}'/>
        /// </summary>
        /// <param name="fields">The fields defined by the record</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The record type</typeparam>
        [Op, Closures(Closure)]
        public static DynamicRows<T> rows<T>(in RecordFields fields, ReadOnlySpan<T> src)
            where T : struct
        {
            var count = (uint)src.Length;
            var buffer = rows<T>(count);
            load(fields, src, buffer);
            return buffer;
        }

        /// <summary>
        /// Allocates a <see cref='DynamicRows{T}' /> index
        /// </summary>
        /// <param name="fields">The fields defined by the record</param>
        /// <param name="rowcount">The number of rows to allocate</param>
        /// <typeparam name="T">The record type</typeparam>
        [Op, Closures(Closure)]
        public static DynamicRows<T> rows<T>(uint rowcount)
            where T : struct
                => sys.alloc<DynamicRow<T>>(rowcount);
    }
}