//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    partial struct Table
    {

        public static WfDataFlow<TableEmission<F,T>,FilePath> emit<F,T>(in TableEmission<F,T> src, FilePath dst, IRowFormatter<F> formatter, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
            where T : struct, ITable<F,T>
        {
            var header = header<F>(delimiter);
            var count = src.RowCount;
            var rows = src.View;

            using var writer = dst.Writer();
            writer.WriteLine(header.HeaderText);

            for(var i=0u; i<count; i++)
                writer.WriteLine(formatter.Format(skip(rows,i)));
            return (src,dst);
        }

        public static WfDataFlow<Dictionary<string,E>,FilePath> emit<E>(Dictionary<string,E> src, FilePath dst)
            where E : unmanaged, Enum
        {
            var header = text.concat("Seq". PadRight(10), SpacePipe, typeof(E).Name);

            using var writer = dst.Writer();
            writer.WriteLine(header);

            var keys = src.Keys.ToArray();
            Array.Sort(keys);
            for(var i=0; i<keys.Length; i++)
                writer.WriteLine(FormatSequential(i, src[keys[i]]));
            return (src,dst);
        }

        /// <summary>
        /// Stores the dataset supplied by <see cref='Enums.index{E}'/>
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="E">The enum type</typeparam>
        public static WfDataFlow<EnumLiteralDetails<E>,FilePath> emit<E>(in EnumLiteralDetails<E> src, FilePath dst)
            where E : unmanaged, Enum
        {
            var name = typeof(E).Name;
            var header = text.concat("Sequence". PadRight(10), SpacePipe, typeof(E).Name);
            using var writer = dst.Writer();
            writer.WriteLine(header);

            for(var i=0; i<src.Length; i++)
            {
                var literal = src[i];
                writer.WriteLine(FormatSequential((int)literal.Position, literal.LiteralValue));
            }
            return (src,dst);
        }

        static string FormatSequential<E>(int seq, E value)
            => text.concat(seq.ToString().PadRight(10), SpacePipe, value.ToString());
    }
}