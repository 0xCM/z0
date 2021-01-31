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
        public asci2 Content {get;}

        [MethodImpl(Inline)]
        public RegDigitExpr(string src)
            => Content = src;

        [MethodImpl(Inline)]
        public RegDigitExpr(in asci2 src)
            => Content = src;

        /// <summary>
        /// The expression length
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => Content.Length;
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

        [MethodImpl(Inline)]
        public bool Equals(RegDigitExpr src)
            => src.Content.Equals(Content);

        public override bool Equals(object src)
            => src is RegDigitExpr x && Equals(x);

        public override int GetHashCode()
            => Content.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator TextBlock(RegDigitExpr src)
            => new TextBlock(src.Text);

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