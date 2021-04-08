//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Part;

    public readonly struct AsmExpr : ITextual
    {
        public TextBlock Content {get;}

        [MethodImpl(Inline)]
        public AsmExpr(TextBlock src)
        {
            Content = src.ToLower();
        }

        [MethodImpl(Inline)]
        public AsmExpr(ReadOnlySpan<char> src)
        {
            Content =  new string(src);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Content;

        [MethodImpl(Inline)]
        public string Format(byte width)
            => string.Format(RP.slot(0,(short)-width), Content);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmExpr(string src)
            => new AsmExpr(new TextBlock(src));

        [MethodImpl(Inline)]
        public static implicit operator AsmExpr(TextBlock src)
            => new AsmExpr(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmExpr(ReadOnlySpan<char> src)
            => new AsmExpr(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmExpr(Span<char> src)
            => new AsmExpr(src);

        public static AsmExpr Empty
        {
            [MethodImpl(Inline)]
            get => new AsmExpr(TextBlock.Empty);
        }
    }
}