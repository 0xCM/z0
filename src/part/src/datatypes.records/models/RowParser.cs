//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Parsers;
    using static Part;

    public readonly struct RowParser<T> : IRowParser<T>
        where T : struct, IRecord<T>
    {
        public char FieldDelimiter {get;}

        readonly ParseFunction<T> F;

        [MethodImpl(Inline)]
        public RowParser(ParseFunction<T> f, char Delimiter)
        {
            FieldDelimiter = Delimiter;
            F = f;
        }

        public Outcome ParseHeader(string src, out RowHeader dst)
            => RecUtil.ParseHeader(src, FieldDelimiter, out dst);

        public Outcome ParseRow(string src, out T dst)
            => F(src, out dst);
    }
}