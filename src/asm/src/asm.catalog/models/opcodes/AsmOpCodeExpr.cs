//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /* Examples:
    04 ib
    05 iw
    05 id
    REX.W+ 05 id
    80 /0 ib
    REX+ 80 /0 ib
    81 /0 iw
    81 /0 id
    REX.W+ 81 /0 id
    83 /0 ib
    83 /0 ib
    REX.W+ 83 /0 ib
    00 /r
    REX+ 00 /r
    01 /r
    01 /r
    REX.W+ 01 /r
    02 /r
    REX+ 02 /r
    03 /r
    03 /r
    REX.W+ 03 /r
    */

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