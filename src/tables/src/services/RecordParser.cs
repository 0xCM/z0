//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Tables;

    public readonly struct RecordParser<T> : IRecordParser<T>
        where T : struct
    {
        public char FieldDelimiter {get;}

        public byte FieldCount {get;}

        readonly RowParser<T> F;

        [MethodImpl(Inline)]
        public RecordParser(RowParser<T> f, byte fields, char Delimiter)
        {
            FieldDelimiter = Delimiter;
            F = f;
            FieldCount = fields;
        }

        public Outcome ParseHeader(TextLine src, out RowHeader dst)
            => Tables.header(src, FieldDelimiter, FieldCount, out dst);

        public Outcome ParseRow(TextLine src, out T dst)
            => F(src, out dst);
    }
}