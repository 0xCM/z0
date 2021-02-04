//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmExpr
    {
        public readonly struct RegDigit : ITextExpr<RegDigit>
        {
            readonly TextBlock Data;

            [MethodImpl(Inline)]
            public RegDigit(string src)
                => Data = src;

            public string Content
            {
                [MethodImpl(Inline)]
                get => Data.Text;
            }

            public int Length
            {
                [MethodImpl(Inline)]
                get => Data.Length;
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Data.IsEmpty;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => Data.IsNonEmpty;
            }

            public override int GetHashCode()
                => Data.GetHashCode();

            [MethodImpl(Inline)]
            public string Format()
                => Data.Format();

            [MethodImpl(Inline)]
            public bool Equals(RegDigit src)
                => Data.Equals(src.Data);

            public override bool Equals(object src)
                => src is RegDigit x && Equals(x);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator TextBlock(RegDigit src)
                => new TextBlock(src.Content);

            [MethodImpl(Inline)]
            public static implicit operator RegDigit(string src)
                => new RegDigit(src);

            public static RegDigit Empty
                => new RegDigit(EmptyString);
        }
    }
}