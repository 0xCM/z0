//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Tables
    {
        [MethodImpl(Inline)]
        public static RecordParser<T> parser<T>(ParserDelegate<T> f, char delimiter = FieldDelimiter)
            where T : struct, IRecord<T>
                => new RecordParser<T>(f, delimiter);
    }
}