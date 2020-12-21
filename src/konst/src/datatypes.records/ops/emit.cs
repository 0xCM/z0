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

    partial struct Records
    {
        /// <summary>
        /// Loads a <see cref='DynamicRows{T}' /> index from a specified source <see cref='ReadOnlySpan{T}'/>
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The record type</typeparam>
        [Op, Closures(Closure)]
        public static TableEmission<DynamicRow<T>> emit<T>(DynamicRows<T> src, in RowFormatSpec spec, FS.FilePath dst)
            where T : struct
        {
            var count = src.Count;
            var data = src.Items;
            using var writer = dst.Writer();
            writer.WriteLine(RowFormat.format(spec.Header));
            var buffer = Buffers.text();
            for(var i=0; i<count; i++)
            {
                RowFormat.render(skip(data,i), spec, buffer);
                writer.WriteLine(buffer.Emit());
            }

            return emission(src, dst);
        }

        [Op, Closures(Closure)]
        public static TableEmission<T> emit<T>(Index<T> src, FS.FilePath dst, RowHeader header, IRowFormatter<T> formatter)
            where T : struct
        {
            var count = src.Count;
            var data = src.Items;

            using var writer = dst.Writer();
            writer.WriteLine(RowFormat.format(header));
            ref readonly var row = ref src.First;
            for(var i=0u; i<count; i++)
                writer.WriteLine(formatter.Format(skip(row,i)));
            return emission(src.Storage, dst);
        }
    }
}