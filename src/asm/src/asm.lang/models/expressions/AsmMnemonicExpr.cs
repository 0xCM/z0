//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmMnemonicExpr : ITextExpr<AsmMnemonicExpr>
    {
        TextBlock Content {get;}

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

        public TextBlock Text
        {
            [MethodImpl(Inline)]
            get => Content;
        }

        public string String
        {
            [MethodImpl(Inline)]
            get => Content.String;
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
        public static implicit operator AsmMnemonicExpr(string src)
            => new AsmMnemonicExpr(src);

        [MethodImpl(Inline)]
        public static bool operator ==(AsmMnemonicExpr a, AsmMnemonicExpr b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(AsmMnemonicExpr a, AsmMnemonicExpr b)
            => !a.Equals(b);

        public static AsmMnemonicExpr Empty
        {
            [MethodImpl(Inline)]
            get => new AsmMnemonicExpr(TextBlock.Empty);
        }
    }
}