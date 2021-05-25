//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct Tables
    {
        const NumericKind Closure = UnsignedInts;

        public const string DefaultDelimiter = " | ";
    }

    partial class XTend
    {
        public static TableReader<T> TableReader<T>(this FS.FilePath src, bool header = true)
            where T : struct, IRecord<T>
                => new TableReader<T>(src, header);

        public static TableReader<T> TableReader<T>(this FS.FilePath src, RecordParseFunction<T> parser, bool header = true)
            where T : struct, IRecord<T>
                => new TableReader<T>(src, parser, header);


        public static RowHeader ToRowHeader(this TextDocHeader src, string delimiter, ReadOnlySpan<byte> widths)
        {
            var labels = src.Labels.View;
            var count = min(labels.Length,widths.Length);
            var cells = new HeaderCell[count];
            ref var dst = ref first(cells);
            for(var i=0u; i<count; i++)
                seek(dst,i) = new HeaderCell(i,skip(labels,i), skip(widths,i));
            return new RowHeader(cells, delimiter);
        }
    }

    partial struct Msg
    {
        public static MsgPattern<uint,uint> RecordFieldWidthMismatch
            => "The record field count of {0} does not match the supplied width count of {1}";
    }
}