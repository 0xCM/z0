//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmMnemonicExpr : ITextual
    {
        public asci32 Content {get;}

        [MethodImpl(Inline)]
        public AsmMnemonicExpr(asci32 name)
            => Content = name;

        [MethodImpl(Inline)]
        public AsmMnemonicExpr(string src)
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

        [MethodImpl(Inline)]
        public bool Equals(AsmMnemonicExpr src)
             => src.Content.Equals(Content);

        public override bool Equals(object src)
            => src is AsmMnemonicExpr x && Equals(x);

        public override int GetHashCode()
            => Content.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmMnemonicExpr(string name)
            => new AsmMnemonicExpr(name);

        [MethodImpl(Inline)]
        public static implicit operator AsmMnemonicExpr(asci32 src)
            => new AsmMnemonicExpr(src);

        public static AsmMnemonicExpr Empty
        {
            [MethodImpl(Inline)]
            get => new AsmMnemonicExpr(asci32.Null);
        }
    }
}