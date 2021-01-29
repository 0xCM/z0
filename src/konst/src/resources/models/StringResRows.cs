//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct StringResRows
    {
        readonly TableSpan<StringResRow> Data;

        [MethodImpl(Inline)]
        public StringResRows(StringResRow[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator StringResRows(StringResRow[] src)
            => new StringResRows(src);

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ReadOnlySpan<StringResRow> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }
    }
}