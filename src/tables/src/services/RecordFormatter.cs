//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct RecordFormatter<T> : IRecordFormatter<T>
        where T : struct, IRecord<T>
    {
        public RowFormatSpec FormatSpec {get;}

        readonly RowAdapter<T> Adapter;

        [MethodImpl(Inline)]
        public RecordFormatter(RowFormatSpec spec)
        {
            FormatSpec = spec;
            Adapter = Tables.adapter<T>();
        }

        [MethodImpl(Inline)]
        string Format(in DynamicRow<T> src)
        {
            var content = string.Format(FormatSpec.Pattern, src.Cells);
            var pad = FormatSpec.RowPad;
            if(pad == 0)
                return content;
            else
                return content.PadRight(pad);
        }

        public string Format(in T src)
            => Format(Adapter.Adapt(src).Adapted);

        public string Format(in T src, RecordFormatKind kind)
        {
            if(kind == RecordFormatKind.Tablular)
                return Format(src);
            else
                return FormatKeyedValues(src);
        }

        const string KVRP = "{0,-48}: {1}" + Eol;

        string FormatKeyedValues(in T src)
        {
            const char RowSep = Chars.Comma;
            const char ValSep = Chars.Eq;
            var adapter = Adapter.Adapt(src);
            var dst = text.buffer();
            var cells = adapter.Cells;
            var count = cells.Length;
            var fields = adapter.Fields.View;
            for(var i=0; i<count; i++)
                dst.AppendFormat(KVRP, skip(fields,i).Name, skip(cells,i));
            return dst.Emit();
        }

        public string FormatHeader()
            => FormatSpec.Header.Format();
    }
}