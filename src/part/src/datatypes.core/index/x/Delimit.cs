//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XIndex
    {
        [MethodImpl(Inline)]
        public static DelimitedIndex<T> Delimit<T>(this IIndex<T> src, char delimiter = Chars.Comma)
            => new DelimitedIndex<T>(src.Storage, delimiter);
    }
}