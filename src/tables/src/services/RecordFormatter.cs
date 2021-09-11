//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Tables;

    public sealed class RecordFormatter : IRecordFormatter
    {
        public static IRecordFormatter formatter(Type type, ushort rowpad = 0)
            => new RecordFormatter(type, EmptyString, default, rowpad);

        public static IRecordFormatter formatter(Type type, ReadOnlySpan<byte> widths, ushort rowpad = 0)
            => new RecordFormatter(type, EmptyString, widths, rowpad);

        public static IRecordFormatter formatter(Type type, string name, ushort rowpad = 0)
            => new RecordFormatter(type, name, default, rowpad);

        internal RecordFormatter(Type type, string name, ReadOnlySpan<byte> widths, ushort rowpad)
        {
            RecordType = type;
            TableId = text.empty(name) ? api.identify(type) : api.identify(type,name);
            FormatSpec = widths.IsEmpty ? api.rowspec(type,api.DefaultFieldWidth,rowpad) : api.rowspec(type, widths, rowpad);
        }

        public Type RecordType {get;}

        public TableId TableId {get;}

        public RowFormatSpec FormatSpec {get;}

        public string Format(ValueType src)
        {
            throw new NotImplementedException();
        }

        public string Format(ValueType src, RecordFormatKind kind)
        {
            throw new NotImplementedException();
        }

        public string FormatHeader()
            => FormatSpec.Header.Format();

    }
}