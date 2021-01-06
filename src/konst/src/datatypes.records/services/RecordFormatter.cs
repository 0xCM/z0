//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RecordFormatter<T> : IRecordFormatter<T>
        where T : struct, IRecord<T>
    {
        public RowFormatSpec FormatSpec {get;}

        readonly RowAdapter<T> Adapter;

        [MethodImpl(Inline)]
        internal RecordFormatter(RowFormatSpec spec)
        {
            FormatSpec = spec;
            Adapter = Records.adapter<T>();
        }

        public string Format(in DynamicRow<T> src)
            => string.Format(FormatSpec.Pattern, src.Cells);

        public string Format(in T src)
            => Format(Adapter.Adapt(src).Adapted);

        public string FormatHeader()
            => FormatSpec.Header.Format();
    }
}