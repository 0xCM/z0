//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmOpCodeExpr : ITextExpr<AsmOpCodeExpr>
    {
        public asci32 Content {get;}

        [MethodImpl(Inline)]
        public AsmOpCodeExpr(asci32 src)
            => Content = src;

        public ReadOnlySpan<byte> Encoded
        {
            [MethodImpl(Inline)]
            get => Asci.bytes(Content);
        }

        public ReadOnlySpan<char> Decoded
        {
            [MethodImpl(Inline)]
            get => Asci.decode(Content);
        }

        public TextBlock Text
        {
            [MethodImpl(Inline)]
            get => Content.Text;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Content.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Content.IsNonEmpty;
        }


        [MethodImpl(Inline)]
        public bool Equals(AsmOpCodeExpr src)
            => src.Content.Equals(Content);

        public override bool Equals(object src)
            => src is AsmOpCodeExpr x && Equals(x);

        public override int GetHashCode()
            => Content.GetHashCode();

        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();

        public static AsmOpCodeExpr Empty
            => new AsmOpCodeExpr(asci32.Null);
    }
}