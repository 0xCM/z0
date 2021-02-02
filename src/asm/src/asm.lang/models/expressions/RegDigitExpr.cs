//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    /*
    /0
    /1
    /2
    /3
    /4
    /5
    /6
    /7
    */

    public readonly struct RegDigitExpr : ITextExpr<RegDigitExpr>
    {
        public string Content {get;}

        [MethodImpl(Inline)]
        public RegDigitExpr(string src)
            => Content = src;

        public int Length
        {
            [MethodImpl(Inline)]
            get => text.length(Content);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Content);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => text.nonempty(Content);
        }

        public override int GetHashCode()
            => text.hash(Content);

        [MethodImpl(Inline)]
        public string Format()
            => Content ?? EmptyString;

        [MethodImpl(Inline)]
        public bool Equals(RegDigitExpr src)
            => src.Content.Equals(Content);

        public override bool Equals(object src)
            => src is RegDigitExpr x && Equals(x);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator TextBlock(RegDigitExpr src)
            => new TextBlock(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator RegDigitExpr(string src)
            => new RegDigitExpr(src);

        [MethodImpl(Inline)]
        public static implicit operator RegDigitExpr(asci2 src)
            => new RegDigitExpr(src);

        public static RegDigitExpr Empty
            => new RegDigitExpr(asci2.Null);
    }
}