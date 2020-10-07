//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct StringResourceRows
    {
        readonly TableSpan<StringResourceRow> Data;

        [MethodImpl(Inline)]
        public StringResourceRows(StringResourceRow[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator StringResourceRows(StringResourceRow[] src)
            => new StringResourceRows(src);

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ReadOnlySpan<StringResourceRow> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }
    }
}