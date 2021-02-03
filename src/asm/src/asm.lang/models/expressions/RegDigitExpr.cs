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
        readonly TextBlock Data;

        [MethodImpl(Inline)]
        public RegDigitExpr(string src)
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
        public bool Equals(RegDigitExpr src)
            => Data.Equals(src.Data);

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

        public static RegDigitExpr Empty
            => new RegDigitExpr(EmptyString);
    }
}