//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct RecordParser<T> : IRecordParser<T>
        where T : struct, IRecord<T>
    {
        public char FieldDelimiter {get;}

        readonly ParserDelegate<T> F;

        [MethodImpl(Inline)]
        public RecordParser(ParserDelegate<T> f, char Delimiter)
        {
            FieldDelimiter = Delimiter;
            F = f;
        }

        public Outcome ParseHeader(string src, out RowHeader dst)
            => Tables.header(src, FieldDelimiter, out dst);

        public Outcome ParseRow(string src, out T dst)
            => F(src, out dst);
    }
}