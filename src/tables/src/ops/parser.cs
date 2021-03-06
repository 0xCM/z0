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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static RecordParser<T> parser<T>(RowParser<T> f, byte fields, char delimiter = FieldDelimiter)
            where T : struct
                => new RecordParser<T>(f, fields, delimiter);
    }
}