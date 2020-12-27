//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

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
        public static RowsetEmissions<DynamicRow<T>> emit<T>(DynamicRows<T> src, RowFormatSpec spec, FS.FilePath dst)
            where T : struct
        {
            var count = src.Count;
            var data = src.Items;
            using var writer = dst.Writer();
            writer.WriteLine(format(spec.Header));
            var buffer = Buffers.text();
            for(var i=0; i<count; i++)
            {
                render(skip(data,i), spec, buffer);
                writer.WriteLine(buffer.Emit());
            }

            return emission(src, dst);
        }

        [Op, Closures(Closure)]
        public static TableEmission<T> emit<T>(Index<T> src, RowFormatSpec spec, FS.FilePath dst)
            where T : struct
        {
            var count = src.Count;
            var data = src.View;
            var formatter = Records.formatter<T>(spec);
            using var writer = dst.Writer();
            writer.WriteLine(format(spec.Header));
            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(data,i)));

            return emission(src, dst);
        }

        [Op, Closures(Closure)]
        public static TableEmission<T> emit<T>(Index<T> src, ReadOnlySpan<byte> widths, FS.FilePath dst)
            where T : struct
                => emit(src, rowspec<T>(widths), dst);
    }
}