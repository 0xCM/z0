//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct StringTableCell : ITextual
    {
        string Data;

        [MethodImpl(Inline)]
        public static implicit operator StringTableCell(string src)
            => new StringTableCell(src);

        [MethodImpl(Inline)]
        public StringTableCell(string src)
            => Data = src;

        [MethodImpl(Inline)]
        public string Format()
            => Data;

        public string Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public StringTableCell Fill(in string src)
        {
            Data = src;
            return this;
        }

        [MethodImpl(Inline)]
        public override string ToString()
            => Format();
    }
}