//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct StringTableCell<T> : ITextual
        where T : ITextual              
    {
        public readonly T Data;

        [MethodImpl(Inline)]
        public static implicit operator StringTableCell(StringTableCell<T> src)
            => new StringTableCell(src.Format());

        [MethodImpl(Inline)]
        public StringTableCell(T src)
            => Data = src;

        [MethodImpl(Inline)]
        public string Format()
            => Data.Format();
    }

    public readonly struct StringTableCell : ITextual
    {
        public readonly string Data;

        [MethodImpl(Inline)]
        public static implicit operator StringTableCell(string src)
            => new StringTableCell(src);

        [MethodImpl(Inline)]
        public StringTableCell(string src)
            => Data = src;

        [MethodImpl(Inline)]
        public string Format()
            => Data;
    }
}