//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct StringTableCell<T> : ITextual
    {
        T Data;

        [MethodImpl(Inline)]
        public static implicit operator StringTableCell(StringTableCell<T> src)
            => new StringTableCell(src.Format());

        [MethodImpl(Inline)]
        public static implicit operator StringTableCell<T>(T src)
            => new StringTableCell<T>(src);

        [MethodImpl(Inline)]
        public StringTableCell(T src)
            => Data = src;

        public readonly T Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public StringTableCell<T> Fill(in T src)
        {
            Data = src;
            return this;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Data.ToString();

        [MethodImpl(Inline)]
        public override string ToString()
            => Format();
    }
}