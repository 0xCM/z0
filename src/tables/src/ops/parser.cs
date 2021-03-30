//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Tables
    {
        [MethodImpl(Inline)]
        public static RowParser<T> parser<T>(ParseFunction<T> f, char delimiter = FieldDelimiter)
            where T : struct, IRecord<T>
                => new RowParser<T>(f, delimiter);
    }
}